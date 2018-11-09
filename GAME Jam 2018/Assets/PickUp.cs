using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour {
	public GameObject son;
	public Vector3 offset;
	private int x = 0;
	private int isPickedUp = 0;
	// Use this for initialization
	void Start () 
	{

			
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (x != 0 && isPickedUp == 1)  
		{
			Debug.Log ("Picked up");
			transform.position = son.transform.position + offset;
		}

		if(Input.GetKeyDown(KeyCode.O))
		{
			if (isPickedUp == 1) 
			{
				isPickedUp = 0;
			
			}

			else if (isPickedUp == 0) 
			{
				isPickedUp = 1;
			}

		}
		

		


	}

	void OnCollisionEnter2D (Collision2D col)
	{
		if (col.gameObject.tag == "Son") 
		{
			Debug.Log ("Player in area");
			Debug.Log ("Pick up plank");
			x = 1;
		}

	}
	void OnCollisionExit2D (Collision2D col)
	{
		x = 0;
	}

}
