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

public class AttachCamController : EditorWindow
{
    public static DropdownField m_dropDown;
    public static DropdownField m_orientationDropdown;
    private static List<string> listOfCameras = new List<string>();

    [MenuItem("USD/Previsualization Panels/Add Camera Controller", priority = 130)]
    public static void FullDomeView()
    {
        EditorWindow wnd = GetWindow<AttachCamController>();
        wnd.titleContent = new GUIContent("[Previz] Camera Controller");

        // this makes it so that its not resizable
        wnd.minSize = new Vector2(300,140);
        wnd.maxSize = new Vector2(300,140);

        wnd.ShowPopup();
    }

    void CreateGUI() {
        m_dropDown = new DropdownField();
        
        foreach (Camera cam in FindObjectsOfType<Camera>())
        {
            listOfCameras.Add(cam.name);
            m_dropDown.value = cam.name;
        }
        
        m_dropDown.choices = listOfCameras;

        rootVisualElement.Add(new Label("\n Select a camera to attach controller script:"));
        rootVisualElement.Add(m_dropDown);
        rootVisualElement.Add(new Label(""));

        var switchButton = new Button();
        switchButton.text = "Switch to Camera";
        switchButton.clicked += switchCamera;
        rootVisualElement.Add(switchButton);

        var addButton = new Button();
        addButton.text = "Add Camera Controller Script";
        addButton.clicked += addScript;
        rootVisualElement.Add(addButton);

        var removeButton = new Button();
        removeButton.text = "Remove Camera Controller Script";
        removeButton.clicked += removeScript;
        rootVisualElement.Add(removeButton);

    }

    // add camera movement script
    private void addScript() {
        if (m_dropDown.value == null) {
            return;
        }

        GameObject.Find(m_dropDown.value).AddComponent<CameraController>();

        Debug.Log("[PREVIZ] Added the camera controller script to the " + m_dropDown.value + " camera!");
    }

    // remove camera movement script
    private void removeScript() {
        if (m_dropDown.value == null) {
            return;
        }

        if (GameObject.Find(m_dropDown.value).GetComponent<CameraController>() != null) {
            if (Application.isPlaying) {
                Destroy(GameObject.Find(m_dropDown.value).GetComponent<CameraController>());
            } else {
                DestroyImmediate(GameObject.Find(m_dropDown.value).GetComponent<CameraController>());
            }
            Debug.Log("[PREVIZ] Removed the camera controller script from the " + m_dropDown.value + " camera!");
        }
    }

    // switch to selected camera
    private void switchCamera() {
        foreach (string camname in listOfCameras)
        {
            if (camname == m_dropDown.value)
            {
                GameObject.Find(camname).GetComponent<Camera>().enabled = true;
            }
            else
            {
                GameObject.Find(camname).GetComponent<Camera>().enabled = false;
            }
        }
    }
}
