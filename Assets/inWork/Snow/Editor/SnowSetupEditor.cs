using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(SnowSystemContoller))]
public class SnowSetupEditor: Editor {
	public override void OnInspectorGUI(){
		DrawDefaultInspector ();

		SnowSystemContoller snowSC = (SnowSystemContoller)target;
		if(GUILayout.Button("Init Snow Setup")){
			snowSC.InitSnowSetup ();
		}
	}
}
