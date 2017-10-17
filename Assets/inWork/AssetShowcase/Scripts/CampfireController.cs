using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CampfireController : MonoBehaviour {
	bool _isWorking = false;

	public GameObject firePS;
	public GameObject smokePS;
	public GameObject emberPS;
	public Light campfireLight;

	public bool IsWorking{
		get{ return _isWorking;}
		set{
			if(value != _isWorking){
				_isWorking = value;
				firePS.SetActive (value);
				smokePS.SetActive (value);
				emberPS.SetActive (value);

				campfireLight.enabled = value;
			}
		}
	}


}
