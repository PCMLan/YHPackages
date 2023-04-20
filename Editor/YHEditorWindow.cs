using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class YHEditorWindow : EditorWindow
{
    [MenuItem("YHTools/Show")]
    public static void Show()
    {
        CreateWindow<YHEditorWindow>();
    }

    public void OnGUI()
    {
        if (GUILayout.Button("µã»÷"))
        {
            Debug.Log("µã»÷");
        }
    }
}
