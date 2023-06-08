//using UnityEngine;
//using System.Collections;
//using MinecraftTool;
//using UnityEditor;

//[CustomEditor(typeof(MBillboard))]
//public class MBillboardEditor : Editor
//{
//    void OnSceneGUI()
//    {
//        MBillboard t = target as MBillboard;
//        if(!t) return;

//        var origin = t.transform.position;
//        var destiny = t.transform.position + Vector3.up*2;

//        Handles.DrawLine(origin, destiny);
//        Handles.Label(destiny + Vector3.up * .5f
//            , t.transform.name + "\n"
//            + "Active: " + (!t.bPauseBillboard).ToString()
//        );
//    }


//}
