using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorActivation : MonoBehaviour {

	// Use this for initialization

	Animator anime;

	public GameObject PressurePlate;      //needs to be the 'small' cube of pressure plate
	private pressurePlate scriptAccess;

	bool isPressed;

	void Start () 
	{

		scriptAccess = PressurePlate.GetComponent<pressurePlate> ();
		isPressed = scriptAccess.fullPress;	//can be used for activating stuff if needed

		anime = (GetComponent<Animator>());

		isPressed = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		scriptAccess = PressurePlate.GetComponent<pressurePlate> ();

		isPressed = scriptAccess.fullPress;


		if (isPressed) 
			isPressed = false;
		else
			isPressed = true;


		anime.SetBool("isTriggered", isPressed);


		//print (isPressed);
	}
}
