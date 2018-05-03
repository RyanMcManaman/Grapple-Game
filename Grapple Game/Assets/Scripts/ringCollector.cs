using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ringCollector : MonoBehaviour 
{
	float count;

	int i;
	GameObject[] gos;

	bool checker;

	// Use this for initialization
	void Start ()
	{
		count = 0;
		checker = false;
		i = 0;

	}
	
	// Update is called once per frame
	void Update () 
	{
		i++;
		if (i == 60) {
			i = 0;
			print (count);
		}
		if (checker == true) {

			if (count >= 10) 
			{
				Destroy (GameObject.FindWithTag ("end"));
				Destroy (GameObject.FindWithTag ("lose"));
			} else {
				Destroy (GameObject.FindWithTag ("end"));
				Destroy (GameObject.FindWithTag ("win"));
			}
		}

	}




	void OnTriggerEnter(Collider other)   //block is on pressure plate
	{
		
		if (other.gameObject.CompareTag ("ring")) 
		{
			
			count = count + .2500f;
		}
		if (other.gameObject.CompareTag ("Fly")) {
			checker = true;
		}
	}
}
