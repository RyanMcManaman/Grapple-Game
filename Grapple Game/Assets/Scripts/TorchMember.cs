using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// this is the class that you put on torches. 
/// basically all it does is tag the object as "lit" on contact with a torch. 
/// </summary>
public class TorchMember : MonoBehaviour
{
	public Material mat;
  void OnCollisionEnter(Collision collision)
  {
    if (collision.collider.gameObject.tag.Contains("torch"))
	{
		Light light = GetComponent<Light>();
			light.range = 100f;
		this.gameObject.tag = "lit";
		Renderer rend = GetComponent<Renderer>();
		rend.material.shader = Shader.Find("Specular");
		//rend.material.SetColor("_SpecColor", Color.red);
		rend.material = mat;
     }
  }
}
