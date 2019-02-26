using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using System;
using UnityEditor.ProjectWindowCallback;
using System.Text.RegularExpressions;
using System.Text;

public class MyHierarchyMenu 
{
    [MenuItem("HierarchyMenu/Eason")]
    static void HierarchyEason()
    {

    }

    [MenuItem("HierarchyMenu/Yoyo")]
    static void HierarchyYoyo()
    {

    }

    [MenuItem("HierarchyMenu/Birth")]
    static void HierarchyBirth()
    {

    }
    //Unity3D研究院编辑器之重写Hierarchy的右键菜单（二十二）
    [InitializeOnLoadMethod]
    static void StartInitializeOnLoadMethod()
    {
        EditorApplication.hierarchyWindowItemOnGUI += OnHierarchyGUI;
    }

    static void OnHierarchyGUI(int instanceID , Rect selectionRect)
    {
        if(Event.current != null && 
            selectionRect.Contains(Event.current.mousePosition) && 
            Event.current.button == 1 &&
            Event.current.type <= EventType.MouseUp)
        {
            GameObject selectedGameObject = EditorUtility.InstanceIDToObject(instanceID) as GameObject;

            if(selectedGameObject)
            {
                Vector2 mousePosition = Event.current.mousePosition;

                EditorUtility.DisplayPopupMenu(new Rect(mousePosition.x, mousePosition.y, 0, 0), "HierarchyMenu", null);
                Event.current.Use();
            }
        }
    }   
}
