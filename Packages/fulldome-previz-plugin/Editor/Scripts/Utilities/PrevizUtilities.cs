using System.Collections.Generic;
using System.Linq;
using System.IO;
using System;

using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

using Unity.Formats.USD;

public class PrevizUtilities : MonoBehaviour
{

    public static void changeSelection(GameObject gameObj) {
        GameObject[] newSelection = new GameObject[1];
     
        newSelection[0] = gameObj;
        
        Selection.objects = newSelection;
    }

    // look for usd game object, in case of unity recompile after script editing
    public static GameObject findRootUsd() {
        foreach (GameObject rootObject in SceneManager.GetActiveScene().GetRootGameObjects()) {
            if (rootObject.GetComponent<Unity.Formats.USD.UsdAsset>() != null) {
                return rootObject;
            }
        }
        return null;
    }

}
