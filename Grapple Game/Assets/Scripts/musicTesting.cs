using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicTesting : MonoBehaviour {


	public AudioClip collectSound;
	public AudioSource collectSource;


	void Start () 
	{
		collectSource.clip = collectSound;
		collectSource.Play ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
