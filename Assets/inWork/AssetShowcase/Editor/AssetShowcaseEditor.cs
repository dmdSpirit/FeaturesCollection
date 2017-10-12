using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(AssetShowcaseController))]
public class AssetShowcaseEditor: Editor {
	public override void OnInspectorGUI(){
		DrawDefaultInspector ();

		AssetShowcaseController assetSC = (AssetShowcaseController)target;
		if(GUILayout.Button("Set Summer")){
			assetSC.SetSummer ();
		}
		if(GUILayout.Button("Set Winter")){
			assetSC.SetWinter ();
		}
		if(GUILayout.Button("Add Material To List")){
			assetSC.AddMaterialToList ();
		}
	}
}
