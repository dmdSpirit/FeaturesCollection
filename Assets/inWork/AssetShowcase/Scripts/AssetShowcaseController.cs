﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;

public class AssetShowcaseController : MonoBehaviour {
	public float levelOfSnow = 0.45f;
	public float depthOfSnow = 0f;

	public PostProcessingProfile winterProfile;
	public PostProcessingProfile summerProfile;

	public GameObject newMaterial;
	public List<Material> assetsMaterialList;
	public PostProcessingBehaviour ppBehaviour;

	Shader standartShader;
	Shader snowShader;

	void Start(){
		//assetsMaterialList = new List<Material> ();
	}

	public void SetSummer(){
		foreach(var material in assetsMaterialList){
			material.shader = Shader.Find("Standard");
		}
		ppBehaviour.profile = summerProfile;
	}

	public void SetWinter(){
		foreach(var material in assetsMaterialList){
			material.shader = Shader.Find("Custom/SnowShader");
		}
		ppBehaviour.profile = winterProfile;
	}

	public void AddMaterialToList(){
		if (newMaterial == null)
			return;
		assetsMaterialList.Add (newMaterial.GetComponent<MeshRenderer> ().sharedMaterial);
		newMaterial = null;
	}
}
