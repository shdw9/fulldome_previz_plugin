using System.Collections.Generic;
using System.Linq;
using System.IO;
using System;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using UnityEditor.PackageManager;

using Unity.Formats.USD;

public class PrevizPlugin : MonoBehaviour
{
    public static GameObject usdScene;

    // modified version of MenuImportAsGameObjects()
    // from com.unity.formats.usd/Editor/Scripts/Behaviors/UsdMenu.cs
    [MenuItem("USD/Import with Timeline Clip", priority = 4)]
    public static void ImportWithTimeline()
    {
        // import usd file
        var scene = Unity.Formats.USD.ImportHelpers.InitForOpen();
        if (scene == null)
        {
            return;
        }

        var usd = Unity.Formats.USD.ImportHelpers.ImportSceneAsGameObject(scene, Selection.activeGameObject);
        scene.Close();

        // create timeline and playable director
        usdScene = GameObject.Find(usd.name);
        var timeline = ScriptableObject.CreateInstance<TimelineAsset>();
        usdScene.AddComponent<PlayableDirector>();
        usdScene.GetComponent<PlayableDirector>().playableAsset = timeline;

        var usdPlayable = timeline.CreateTrack<UsdPlayableTrack>(null, "");
        usdScene.GetComponent<PlayableDirector>().SetGenericBinding(usdPlayable, usdScene.GetComponent<UsdAsset>());

        var usdPlayableClip = usdPlayable.CreateDefaultClip();
        usdPlayableClip.duration = usdScene.GetComponent<Unity.Formats.USD.UsdAsset>().Length;
        var usdPlayableAsset = usdPlayableClip.asset as UsdPlayableAsset;

        usdPlayableAsset.SourceUsdAsset = new ExposedReference<UsdAsset> { exposedName = Guid.NewGuid().ToString() };
        usdScene.GetComponent<PlayableDirector>().SetReferenceValue(usdPlayableAsset.SourceUsdAsset.exposedName, usdScene.GetComponent<UsdAsset>());

        Debug.Log("[PREVIZ] Successfully imported" + usd.name + " with a timeline clip length of " + usdPlayableClip.duration + " seconds");
    }

    [MenuItem("USD/Export Scene with Unity Recorder", priority = 50)]
    public static void OpenRecorderWindow()
    {
        // Open the Unity Recorder Window To Export USD
        EditorWindow window = EditorWindow.GetWindow(typeof(UnityEditor.Recorder.RecorderWindow));
        window.Show();
        window.Focus();
    }

    [MenuItem("USD/Previsualization Panels/Animation Window", priority = 160)]
    public static void AnimatorWindow()
    {
        System.Type windowType = typeof(UnityEditor.Editor).Assembly.GetType("UnityEditor.AnimationWindow");
        EditorWindow window = EditorWindow.GetWindow(windowType);
        window.Show();
        window.Focus();
    }

    [MenuItem("USD/Previsualization Panels/USD Recorder Window", priority = 190)]
    public static void RecorderWindow()
    {
        EditorWindow window = EditorWindow.GetWindow(typeof(UnityEditor.Recorder.RecorderWindow));
        window.Show();
        window.Focus();
    }

    

}
