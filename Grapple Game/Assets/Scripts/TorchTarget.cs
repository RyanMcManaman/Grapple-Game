using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//this is an effect independent script that you can use to activate an object
//when all torches are lit up.
public class TorchTarget : MonoBehaviour {
  public GameObject[] Torches;
	// Update is called once per frame
	void Update () {
    int i = 0;
		foreach(GameObject obj in Torches)
    {
      if (obj.tag.Contains("alight"))
      {
        i++;
      }
    }
    if (i >= Torches.Length)
    {
      if (!this.gameObject.tag.Contains("activated"))
        this.gameObject.tag = this.gameObject.tag + " activated";
    }
	}
}
