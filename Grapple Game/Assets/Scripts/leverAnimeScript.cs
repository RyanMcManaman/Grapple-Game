using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leverAnimeScript : MonoBehaviour 
{


	Animator animator;


	// Use this for initialization
	void Start () 
	{
		animator = GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () 
	{
		

	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("leverTrigger")) 
		{
			animator.SetBool("isTriggered",true);
		}

	}



	void OnTriggerStay(Collider other)
	{
		if (other.gameObject.CompareTag ("leverTrigger")) 
		{
			animator.SetBool("isTriggered",true);
		}

	}


}
