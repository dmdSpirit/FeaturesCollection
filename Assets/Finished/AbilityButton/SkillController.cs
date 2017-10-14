using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SkillController : MonoBehaviour {
	[SerializeField]
	Text cooldownText;
	[SerializeField]
	int abilityCooldown = 5;
	[SerializeField]
	KeyCode abilityKey;

	public Text abilityKeyText;

	bool _isUsable;
	bool isUsable{
		get{ return _isUsable;}
		set{
			if(value != _isUsable){
				_isUsable = value;
				abitilyButton.interactable = value;
				cooldownText.gameObject.SetActive (!value);
			}
		}
	}

	Button abitilyButton;

	void Awake(){
		abitilyButton = GetComponent<Button> ();
	}

	void Start(){
		isUsable = true;
		if (abilityKey != null)
			abilityKeyText.text = abilityKey.ToString ();
	}

	// To use by key pressing.
	void Update(){
		if (isUsable && abilityKey != null && Input.GetKeyDown (abilityKey))
			CastAbility ();
	}

	public void CastAbility(){

		// Add ability function here.

		StartCoroutine (Cooldown());
	}


	IEnumerator Cooldown(){
		isUsable = false;
		for(int i=abilityCooldown; i>0; i--){
			cooldownText.text = i.ToString();
			yield return new WaitForSeconds (1);
		}
		isUsable = true;
	}
}
