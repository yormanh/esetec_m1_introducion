//using UnityEngine;
//using UnityEditor;

//namespace MinecraftTool
//{
	
//	public class MBillboard : MonoBehaviour 
//	{	
//		public bool bPauseBillboard;

//		void OnRenderObject()
//		{
//			if(bPauseBillboard) return;
			
//			Camera sceneCamera = !EditorApplication.isPlaying
//			? SceneView.lastActiveSceneView.camera
//			: Camera.main;

//			if(sceneCamera)
//			{
//				var dir = sceneCamera.transform.position - transform.position;
//				dir.y = 0;
//				dir.Normalize();

//				transform.rotation = Quaternion.LookRotation(-dir);
//			}
//		}
//	}

//}
