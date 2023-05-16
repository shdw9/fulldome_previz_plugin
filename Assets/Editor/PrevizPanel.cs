using System.Collections.Generic;
using System.IO;
using System;

using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.Playables;
using UnityEngine.Timeline;

using Unity.Formats.USD;

public class PrevizPanel : EditorWindow
{

    // modified version of MenuImportAsGameObjects()
    // from com.unity.formats.usd/Editor/Scripts/Behaviors/UsdMenu.cs
    [MenuItem("USD/Import as GameObjects with Timeline", priority = 0)]
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
        var usdScene = GameObject.Find(usd.name);
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

        Debug.Log("Successfully imported" + usd.name + " with a timeline clip length of " + usdPlayableClip.duration + " seconds");
    }

    [MenuItem("USD/Export USD with Recorder", priority = 50)]
    public static void OpenRecorderWindow()
    {
        // Open the Unity Recorder Window To Export USD
        EditorWindow window = EditorWindow.GetWindow(typeof(UnityEditor.Recorder.RecorderWindow));
        window.Show();
        window.Focus();
    }

    [MenuItem("USD/Open PrevizPanel", priority = 150)]
    public static void ShowMyEditor()
    {
        // This method is called when the user selects the menu item in the Editor
        EditorWindow wnd = GetWindow<PrevizPanel>();
        wnd.titleContent = new GUIContent("test");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
