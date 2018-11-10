using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FatherWalkScript : MonoBehaviour {

	public float MoveSpeed;
	public float JumpPower;
	private bool OnGround=true;
	Animator myAnim;


	SpriteRenderer SR;

	private bool isMoving = false;

	//4.14 1.86 -10 2 2 2 t


	// Use this for initialization
	void Start () 
	{
		SR = GetComponent<SpriteRenderer> ();
		myAnim = GetComponent<Animator> ();

	}

	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKey (KeyCode.D)) {
			transform.Translate (Vector3.right * MoveSpeed * Time.deltaTime);
			isMoving = true;
			myAnim.SetBool ("father walking", isMoving);

		}

		if (Input.GetKey (KeyCode.A)) {
			transform.Translate (Vector3.left * MoveSpeed * Time.deltaTime);
			isMoving = true;
			myAnim.SetBool ("father walking left", isMoving);

		}

		if (OnGround == true) {
			if (Input.GetKey (KeyCode.Return)) {
				transform.Translate (Vector2.up * JumpPower);
				OnGround = false;
			}
		}

		if (isMoving && !Input.GetKey ("a") && !Input.GetKey ("d")) 
		{
			isMoving = false;
			myAnim.SetBool ("father walking", isMoving);
			myAnim.SetBool ("father walking left", isMoving);
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
