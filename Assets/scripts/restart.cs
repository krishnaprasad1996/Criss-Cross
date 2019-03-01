using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour {
	
	public GameObject res;
	public GameObject game;

	// Use this for initialization
	void onClick () {
		res.SetActive (false);
		game.SetActive (true);
		//SceneManager.LoadScene ("scene1");



	}
	
	// Update is called once per frame
	void Update () {

	}
}
