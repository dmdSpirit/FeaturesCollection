using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowSystemContoller : MonoBehaviour {
	public GameObject snowSurface;
	public Camera snowCamera;
	public GameObject floor;

	public float snowDepth = 0.5f;
	public float cameraDisplacement = 0.2f;
	public float snowRenderTextureResolution = 10;

	RenderTexture snowRenderTexture;

	void Start(){
		InitSnowSetup ();
	}
		
	public void InitSnowSetup(){
		snowSurface.transform.position = new Vector3 (0, snowDepth, 0);
		Vector3 floorSize = floor.transform.localScale;
		snowSurface.transform.localScale = floorSize;

		//Vector3 snowRenderTextureSize = floorSize * 10 * snowRenderTextureResolution;
		//snowRenderTexture = new RenderTexture ((int)snowRenderTextureSize.x, (int)snowRenderTextureSize.z, 16);
		//snowRenderTexture.Create ();
		//snowRenderTexture.name = "SnowRenderTexture";

		snowCamera.transform.position = new Vector3 (0, -cameraDisplacement, 0);
		snowCamera.nearClipPlane = cameraDisplacement - 0.1f;
		snowCamera.farClipPlane = cameraDisplacement + snowDepth;
		snowCamera.transform.localRotation = Quaternion.LookRotation(new Vector3(0,1,0), new Vector3(0,0,-1));
		snowCamera.targetTexture = snowRenderTexture;
		snowCamera.orthographicSize = floorSize.x * 5;

		//MeshRenderer snowSurfaceMR = snowSurface.GetComponent<MeshRenderer> ();
		//snowSurfaceMR.sharedMaterial.SetTexture ("Albedo", snowRenderTexture);

		snowCamera.depthTextureMode = DepthTextureMode.Depth;
	}
}
