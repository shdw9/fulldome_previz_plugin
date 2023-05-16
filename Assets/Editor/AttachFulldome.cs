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

public class AttachFulldome : EditorWindow
{

    [MenuItem("USD/Panels/FullDome View", priority = 150)]
    public static void FullDomeView()
    {
        // This method is called when the user selects the menu item in the Editor
        EditorWindow wnd = GetWindow<AttachFulldome>();
        wnd.titleContent = new GUIContent("Fulldome View");
    }

    public void CreateGUI() {
        rootVisualElement.Add(new Label("Hello"));
    }

}
