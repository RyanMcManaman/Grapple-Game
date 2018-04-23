using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorForTorches : MonoBehaviour 
{

	Animator anime;


	public GameObject torchTarget;      //needs to be the 'small' cube of pressure plate
	private TorchTarget scriptAccess;

	bool isActive;


	// Use this for initialization
	void Start () 
	{
		scriptAccess = torchTarget.GetComponent<TorchTarget> ();
		isActive = scriptAccess.active;	//can be used for activating stuff if needed

		anime = (GetComponent<Animator>());

		isActive = false;
	}
	
	// Update is called once per frame
	void Update () 
	{


		scriptAccess = torchTarget.GetComponent<TorchTarget> ();

		isActive = scriptAccess.active;


		if (isActive) 
			isActive = false;
		else
			isActive = true;





		anime.SetBool("isTriggered", isActive);
	}
}
