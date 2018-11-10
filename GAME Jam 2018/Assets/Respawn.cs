using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {
	public Vector2 SonSpawn;
	public Vector2 DadSpawn;
	public Vector2 PlankSpawn;
	public Vector2 CrateSpawn;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnTriggerEnter2D (Collider2D other)
	{
		Debug.Log ("Object Fell");

		if (other.gameObject.tag == "Son") 
		{
			other.transform.position = SonSpawn;
		}

		if (other.gameObject.tag == "Father") 
		{
			other.transform.position = DadSpawn;
		}

		if (other.gameObject.tag == "Plank") 
		{
			other.transform.position = PlankSpawn;
		}

		if (other.gameObject.tag == "Crate") 
		{
			other.transform.position = CrateSpawn;
		}

	}
}
