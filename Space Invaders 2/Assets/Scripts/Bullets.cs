using UnityEngine;
using System.Collections;

public class Bullets : MonoBehaviour {

	private float bulletlife;
	// Use this for initialization
	void Start ()
	{
		bulletlife = 0f;
	}
	
	// Update is called once per frame
	void Update ()
	{
		bulletlife = bulletlife + Time.deltaTime;
		if (bulletlife >= 0.5f)
		{
			Destroy (this.gameObject);
		}
	}
}
