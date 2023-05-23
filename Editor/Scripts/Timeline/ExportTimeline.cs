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
public class ExportTimeline : MonoBehaviour
{
    [MenuItem("USD/Timeline/Export Timeline Information", priority = 190)]
    public static void ExportToJson()
    {
        var usdScene = PrevizUtilities.findRootUsd();

        if (usdScene == null) {
            Debug.Log("[PREVIZ] Cannot find the imported USD scene! Try importing a USD scene via \"Import with Timeline Clip\"!");
            return;
        }

        if (usdScene.GetComponent<PlayableDirector>() == null) {
            Debug.Log("[PREVIZ] Cannot find the playable director of this USD scene. Try importing the scene via \"Import with Timeline Clip\"!");
            return;
        }

        var timeline = (TimelineAsset) usdScene.GetComponent<PlayableDirector>().playableAsset;
        string timelineJson = "{\"" + usdScene.name + "\": {";
        
        timelineJson += "\"usdPath\": \"" + usdScene.GetComponent<Unity.Formats.USD.UsdAsset>().usdFullPath.Replace("\\","/") + "\", ";
        foreach (TrackAsset track in timeline.GetOutputTracks())
        {
            timelineJson += "\"" + track.ToString().Split('(', ')')[1] + "\": {";
            timelineJson += "\"trackName\": \"" + track.name + "\", ";

            timelineJson += "\"clipInfo\": ";
            timelineJson += JsonUtility.ToJson(track);

            timelineJson += "}}";
            
        }
        timelineJson += "}";

        var path = EditorUtility.SaveFilePanel(
            "[FDP] Save timeline information as JSON",
            "",
            "fdp-timeline.json",
            "json");

        if (path.Length != 0)
        {
            Debug.Log(timelineJson);
            try {
                File.WriteAllText(path, JsonConvert.SerializeObject(JObject.Parse(timelineJson), Formatting.Indented));
            } catch {
                File.WriteAllText(path, timelineJson);
            }
            
            Debug.Log("[PREVIZ] Saved timeline information to " + path + "!");
        }

    }
}
