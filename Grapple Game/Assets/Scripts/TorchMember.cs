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

	void Start ()
	{
		ParticleSystem ps = GetComponent<ParticleSystem> ();
		ps.Stop ();
	}
  void OnCollisionEnter(Collision collision)
  {
    if (collision.collider.gameObject.tag.Contains("torch"))
	{
		Light light = GetComponent<Light>();
		ParticleSystem ps = GetComponent<ParticleSystem> ();
		ps.Play ();
		light.range = 100f;
		this.gameObject.tag = "lit";
		Renderer rend = GetComponent<Renderer>();
		rend.material.shader = Shader.Find("Specular");
		rend.material = mat;
     }
  }
}
