using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class score : MonoBehaviour {
	
	public Text scoretext;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		scoretext.text = "Score :"+Sphere.score;

	}
}
