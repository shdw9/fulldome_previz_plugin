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

    public static DropdownField m_dropDown;

    [MenuItem("USD/Previzualization Panels/FullDome View", priority = 120)]
    public static void FullDomeView()
    {
        EditorWindow wnd = GetWindow<AttachFulldome>();
        wnd.titleContent = new GUIContent("Fulldome View");

        // this makes it so that its not resizable
        wnd.minSize = new Vector2(300,400);
        wnd.maxSize = new Vector2(300,400);
    }

    void CreateGUI() {
        Debug.Log("fdv!");
        m_dropDown = new DropdownField();
        List<string> listOfCameras = new List<string>();

        foreach (Camera cam in FindObjectsOfType<Camera>())
        {
            listOfCameras.Add(cam.name);
            m_dropDown.value = cam.name;
        }
        
        m_dropDown.choices = listOfCameras;

        rootVisualElement.Add(new Label("\nSelect a camera to modify the fulldome camera:"));
        rootVisualElement.Add(m_dropDown);
        rootVisualElement.Add(new Label(""));

        var addButton = new Button();
        addButton.text = "Add Fulldome Rig";
        addButton.clicked += addFulldome;
        rootVisualElement.Add(addButton);

        var removeButton = new Button();
        removeButton.text = "Remove Fulldome Rig";
        removeButton.clicked += removeFulldome;
        rootVisualElement.Add(removeButton);

    }

    private void addFulldome() {
        if (m_dropDown.value == null) {
            return;
        }

        // add object and attach fulldome script to it
        if (GameObject.Find("Fulldome Camera") != null)
        {
            if (Application.isPlaying) {
                Destroy(GameObject.Find("Fulldome Camera"));
            } else {
                DestroyImmediate(GameObject.Find("Fulldome Camera"));
            }
        }

        GameObject gameobj = new GameObject("Fulldome Camera");
        gameobj.AddComponent<Avante.FulldomeCamera>();

        foreach (Camera cam in FindObjectsOfType<Camera>())
        {
            Debug.Log(cam.name);
            if (cam.name == m_dropDown.value)
            {
                gameobj.GetComponent<Avante.FulldomeCamera>().mainCamera = cam;
            }
        }

        gameobj.GetComponent<Avante.FulldomeCamera>().masked = true;
        Debug.Log("[PREVIZ] Turned " + m_dropDown.value + " into a fulldome camera!");
    }

    private void removeFulldome() {
        if (m_dropDown.value == null) {
            return;
        }

        if (GameObject.Find("Fulldome Camera") != null)
        {
            if (Application.isPlaying) {
                Destroy(GameObject.Find("Fulldome Camera"));
            } else {
                DestroyImmediate(GameObject.Find("Fulldome Camera"));
            }
            
        }

        foreach (Camera cam in FindObjectsOfType<Camera>())
        {
            GameObject.Find(m_dropDown.value).GetComponent<Camera>().enabled = true;
        }
    }

}
