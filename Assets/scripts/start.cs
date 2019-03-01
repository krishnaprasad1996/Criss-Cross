using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour {

	// Use this for initialization
	public void onClick()
    {
     
		SceneManager.LoadScene ("scene1");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
