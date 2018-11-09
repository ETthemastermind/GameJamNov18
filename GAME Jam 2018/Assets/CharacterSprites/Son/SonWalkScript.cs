using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonWalkScript : MonoBehaviour {

	public float MoveSpeed;
	public float JumpPower;
	private bool OnGround=true;
	//Animator myAnim;


	SpriteRenderer SR;



	//4.14 1.86 -10 2 2 2 t


	// Use this for initialization
	void Start () 
	{
		SR = GetComponent<SpriteRenderer> ();
		//myAnim = GetComponent<Animator> ();

	}

	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKey (KeyCode.L)) 
		{
			transform.Translate (Vector3.right * MoveSpeed * Time.deltaTime);

		}

		if (Input.GetKey (KeyCode.J)) 
		{
			transform.Translate (Vector3.left * MoveSpeed * Time.deltaTime);

		}

		if (OnGround == true) {
			if (Input.GetKey (KeyCode.I)) {
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








