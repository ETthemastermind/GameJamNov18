using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	public float MoveSpeed;
	public float JumpPower;
	private bool OnGround=true; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.D))
			transform.Translate (Vector3.right * MoveSpeed * Time.deltaTime);
		if (Input.GetKey (KeyCode.A))
			transform.Translate (-Vector2.right * MoveSpeed * Time.deltaTime);
		if (OnGround == true) 
		{
			if (Input.GetKey (KeyCode.W)) 
			{
				transform.Translate (Vector2.up * JumpPower);
				OnGround = false;
			}
		}
			
	}
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Floor") 
		{
			OnGround = true;
		}
	}
}








