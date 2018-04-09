using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// this is an effect independent script that you can use  to tag an object
/// as "activated" an object when all torches are lit up.
/// </summary>
public class TorchTarget : MonoBehaviour {
  public GameObject[] Torches;
	// Update is called once per frame
	void Update () {
    int i = 0;
		foreach(GameObject obj in Torches)
    {
      if (obj.tag.Contains("lit"))
      {
        i++;
      }
    }
    if (i >= Torches.Length)
    {
		//This declares our target, aka: point b
		var target = new Vector3(transform.position.x, transform.position.y+(float).1, transform.position.x);
		//This is our speed. It is SUPER sensitive, so its best to use a float
		var speed = (float)0.5;
		//Start the update function
		//Here's where the magic happens. Lerp is actually giving coordinates for the new position every update.
		transform.position = Vector3.Lerp(transform.position, target, speed);
     
    }
	}
}
