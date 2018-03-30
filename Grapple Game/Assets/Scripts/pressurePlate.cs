using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressurePlate : MonoBehaviour {

	Animator animator;

	float plateX;
	float plateY;
	float plateZ;
	float plateMax;
	float plateMin;

	public Transform plate;

	bool pressed;
	public bool fullPress;

	void Start () 
	{
		pressed = false;
		fullPress = false;
		animator = GetComponent<Animator>();

		plateX = plate.position.x;
		plateY = plate.position.y;
		plateZ = plate.position.z;
		plateMax = plateY;
		plateMin = plateY - .024f;
	}

	void Update () 
	{
		if (pressed == true) //plate goes down
		{

			if (transform.position.y > plateMin) 
			{
				transform.position = new Vector3 (plateX, plateY, plateZ);
				plateY -= .001f;
			}
			if (transform.position.y < plateMin+.0011f) {
				fullPress = false;
			}

		}  else if(pressed == false) //plate goes up
		{
			fullPress = true;
			if (transform.position.y < plateMax) 
			{
				transform.position = new Vector3 (plateX, plateY, plateZ);
				plateY += .001f;
			}  

		}
	}

	void OnTriggerEnter(Collider other)   //block is on pressure plate
	{
		if (other.gameObject.CompareTag ("pressurePlateBox")) 
		{
			pressed = true;
		}
	}


	void OnTriggerExit(Collider other) //block comes off pressure plate
	{
		if (other.gameObject.CompareTag ("pressurePlateBox")) 
		{
			pressed = false;
		}
	}
}
