using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SonWalkScript : MonoBehaviour {

	public float MoveSpeed;
	public float JumpPower;
	private bool OnGround=true;
	private bool CanClimbLadder = false;
	Animator myAnim;
	public float LadderSpeed = 6f;


	SpriteRenderer SR;
	Rigidbody2D RB;

	private bool isMoving = false;

	//4.14 1.86 -10 2 2 2 t


	// Use this for initialization
	void Start () 
	{
		SR = GetComponent<SpriteRenderer> ();
		myAnim = GetComponent<Animator> ();
		RB = GetComponent<Rigidbody2D> ();

	}

	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKey (KeyCode.L)) {
			transform.Translate (Vector3.right * MoveSpeed * Time.deltaTime);
			isMoving = true;
			myAnim.SetBool ("IsWalking", isMoving);

		}

		if (Input.GetKey (KeyCode.J)) {
			transform.Translate (Vector3.left * MoveSpeed * Time.deltaTime);
			isMoving = true;
			myAnim.SetBool ("IsWalkingLeft", isMoving);

		}

		if (OnGround == true) {
			if (Input.GetKey (KeyCode.Return)) {
				transform.Translate (Vector2.up * JumpPower);
				OnGround = false;
			}

		

		}

		if (isMoving && !Input.GetKey ("j") && !Input.GetKey ("l")) 
		{
			isMoving = false;
			myAnim.SetBool ("IsWalking", isMoving);
			myAnim.SetBool ("IsWalkingLeft", isMoving);
		}


		if (CanClimbLadder == true && Input.GetKey (KeyCode.I)) 
		{
			Debug.Log ("Climbing Ladder");
			RB.velocity = new Vector2 (0, LadderSpeed);

		}

	}


		


	
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Floor") 
		{
			OnGround = true;
		}



	}


	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Ladder") 
		{
			Debug.Log ("Can Climb");
			CanClimbLadder = true;


		}
	}

	void OnTriggerExit2D (Collider2D other)
	{
		if (other.gameObject.tag == "Ladder") 
		{
			CanClimbLadder = false;
			Debug.Log ("Can't Climb");


		}
	}






}








