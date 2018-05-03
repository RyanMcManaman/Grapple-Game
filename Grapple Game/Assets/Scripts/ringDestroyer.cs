using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ringDestroyer : MonoBehaviour 
{
	
	// Use this for initialization
	public GameObject ring;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void OnTriggerExit(Collider other)   //block is on pressure plate
	{
		
		if (other.gameObject.CompareTag ("Player"))
		{
			Destroy (ring);

		}



	}
}
