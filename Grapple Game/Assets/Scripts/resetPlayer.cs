

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetPlayer : MonoBehaviour 
{
	float playerX;
	float playerY;
	float playerZ;

	Transform player;

	Rigidbody rb;
	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	
		player = GameObject.FindGameObjectWithTag ("Player").transform;
		playerX = player.position.x;
		playerY = player.position.y;
		playerZ = player.position.z;
	}
		
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("ResetPlayerBox")) 
		{
			player = GameObject.FindGameObjectWithTag ("Player").transform;
			playerX = player.position.x;
			playerY = player.position.y;
			playerZ = player.position.z;
		}
		if (other.gameObject.CompareTag ("ResetPlayer")) 
		{
			print ("helloifnelkfn");
			transform.position = new Vector3 (playerX, playerY, playerZ);
			rb.velocity = Vector3.zero;
			rb.angularVelocity = Vector3.zero;
		}

	}
}
