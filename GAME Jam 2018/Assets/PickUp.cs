using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour {
	public GameObject son;
	public Vector3 offset;
	private int x = 0;
	private int isPickedUp = 0;
    Rigidbody2D Rb;
   




	// Use this for initialization
	void Start () 
	{
        Rb = GetComponent<Rigidbody2D>();

			
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
        Debug.Log("Player in area");

        if (col.gameObject.tag == "Son") 
		{
			Debug.Log ("Player in area");
			Debug.Log ("Pick up plank");
			x = 1;
            Rb.gravityScale = 0;

        }

	}
	void OnCollisionExit2D (Collision2D col)
	{
        Rb.gravityScale = 1;
        x = 0;
	}

}
