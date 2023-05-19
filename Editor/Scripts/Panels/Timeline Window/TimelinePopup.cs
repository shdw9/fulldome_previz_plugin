using System.Collections.Generic;
using System.Linq;
using System.IO;
using System;

using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using UnityEditor.PackageManager;

using Unity.Formats.USD;

public class TimelinePopup : EditorWindow
{

    [MenuItem("USD/Previsualization Panels/Timeline Window", priority = 150)]
    public static void TimelineWindow()
    {
        EditorWindow wnd = GetWindow<TimelinePopup>();
        wnd.titleContent = new GUIContent("Timeline Window");
        wnd.maxSize = new Vector2(400,100);
        wnd.maxSize = new Vector2(400,100);
    }

    void CreateGUI() {
        rootVisualElement.Add(new Label("\nTo open the Timeline Window:\n\nGo under Window > Sequencing > Timeline\n\n* Due to its protection level, we cannot open it through scripting."));
    }

}
