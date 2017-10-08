using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {
	int frameNum;
	public GameObject testObject;

	void Start(){
		frameNum = 1;
	}

	void Update(){
		Debug.Log (Time.frameCount + " : " + frameNum);
		GameObject newObj = Instantiate (testObject);
		newObj.name = frameNum.ToString();
		frameNum++;
	}
}
