using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour {


	private bool SoninArea = false;
	private bool DadinArea = false;

	void OnTriggerEnter2D(Collider2D other)
	{
		
		if (other.gameObject.tag == "Son") {
			Debug.Log ("Son in Area");
			SoninArea = true;

		}

		if (other.gameObject.tag == "Father") {
			Debug.Log ("Dad in Area");
			DadinArea = true;
		}
	}

	void OnTriggerExit2D(Collider2D other)
	{

		if (other.gameObject.tag == "Son") {
			Debug.Log ("Son out of Area");
			SoninArea = false;

		}

		if (other.gameObject.tag == "Father") {
			Debug.Log ("Dad out of Area");
			DadinArea = false;
		}

	}

	void Update ()
	{
		if (DadinArea == true && SoninArea == true) 
		{
			SceneManager.LoadScene(2);

		}
	}




			


	


	

}
