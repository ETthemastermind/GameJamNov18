using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Mouse : MonoBehaviour {

	public Sprite NGsprite;
	public Sprite Gsprite;
	public Sprite Fsprite;
	private bool CanTM = false;
	private AudioSource source;

	public AudioSource AS;

	SpriteRenderer SR;
	BoxCollider2D BC;
	public Movement MS;


	void Start()
	{
		BC = GetComponent<BoxCollider2D> ();
		SR = GetComponent<SpriteRenderer> ();
        



	}
	void OnMouseOver()

	{
		Debug.Log ("Mouse Over");
		SR.sprite = Gsprite;
		CanTM = true;

	}


	void OnMouseExit()
	{
		SR.sprite = NGsprite;
		CanTM = false;
	}

	void Update()
	{
		if (CanTM == true && Input.GetMouseButton (0)) {
			SR.sprite = Fsprite;
			BC.isTrigger = false;
			//source = GetComponent<AudioSource> ();
			//source.PlayOneShot;

			MS.SetIsMoving (false);
			Debug.Log ("FALSE");

		} else if (Input.GetMouseButtonUp (0)) 
		{
			MS.SetIsMoving (true);
			Debug.Log ("TRUE");
		}
		else 
		{
			BC.isTrigger = true;

		}



	}

}
