using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
