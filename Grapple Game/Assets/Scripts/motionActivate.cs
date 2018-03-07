using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class motionActivate : MonoBehaviour {

	//this can be attached to any object and set to move how they want. 

	Animator anime;
	//object to be moved

	public GameObject PressurePlate;      //needs to be the 'small' cube of pressure plate
	private pressurePlate scriptAccess;

	bool isPressed;

	void Start ()
	{
		scriptAccess = PressurePlate.GetComponent<pressurePlate> ();
		isPressed = scriptAccess.fullPress;	//can be used for activating stuff if needed

		anime = (GetComponent<Animator>());
	}

	void Update () 
	{
		scriptAccess = PressurePlate.GetComponent<pressurePlate> ();

		isPressed = scriptAccess.fullPress;
		if (isPressed) {
			anime.enabled = false;
		}  else {
			anime.enabled = true;
		}

	}
}

