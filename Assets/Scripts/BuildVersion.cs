using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;

// Retrieve the build name from PlayerSettings and display it in the UI
public class BuildVersion : MonoBehaviour
{
    [SerializeField] TextMeshPro buildNameText;
    void Start()
    {
        string buildName = Application.version;
        buildNameText.text = "VERSION: BoH APK " + buildName;
    }
}
