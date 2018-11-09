using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimTest : MonoBehaviour {

	public Sprite[] WalkingAnim;
	private int WalkingFrame = 0;
	SpriteRenderer SR;

	// Use this for initialization
	void Start () 
	{
		SR = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.L)) 
		{
			Debug.Log ("Walking");
			WalkingFrame += 1;
			SR.sprite = WalkingAnim[0];


		}
		if (WalkingFrame > 3) 
		{
			WalkingFrame = 0;
		}
	}
}
