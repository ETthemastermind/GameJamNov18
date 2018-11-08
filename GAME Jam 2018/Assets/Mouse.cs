using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour {
	public GameObject Thing;
	void Start()
	{
		Thing.SetActive (false);
		
	}
	void OnMouseEnter()
	{
		Thing.SetActive (true);
	}
}
