using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicTesting : MonoBehaviour {


	public AudioClip section1Music;
	public AudioClip section2Music;
	public AudioClip section3Music;
	public AudioSource musicSource;


	void Start () 
	{
		musicSource.clip = section1Music;
		musicSource.Play ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}



	void OnTriggerExit(Collider other)   //block is on pressure plate
	{

		if (other.gameObject.CompareTag ("section2Music"))
		{
			musicSource.clip = section2Music;
			musicSource.Play ();

		}
		if (other.gameObject.CompareTag ("section3Music"))
		{
			musicSource.clip = section3Music;
			musicSource.Play ();
		}


	}
}
