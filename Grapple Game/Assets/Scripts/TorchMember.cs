using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// this is the class that you put on torches. 
/// basically all it does is tag the object as "lit" on contact with a torch. 
/// </summary>
public class TorchMember : MonoBehaviour {
  void OnCollisionEnter(Collision collision)
  {
    if (collision.collider.gameObject.tag.Contains("torch"))
    {
      if (!this.gameObject.tag.Contains("lit"))
      {
        this.gameObject.tag = this.gameObject.tag + " lit";
      }
    }
  }
}
