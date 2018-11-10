using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class OpenGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Loading Game");
            if (SceneManager.GetActiveScene().buildIndex == 0)
            {
                SceneManager.LoadScene(1);

            }


        }


		
	}
}
