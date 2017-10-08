using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestComponent : MonoBehaviour {
	
	void OnWillRenderObject(){
		Debug.Log (gameObject.name + " OnWillRenderObject by "+Camera.current.name);
	}
}
