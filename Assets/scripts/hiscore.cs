using UnityEngine;

using System.Collections;
using UnityEngine.UI;

public class hiscore : MonoBehaviour {
	public Text hiascore;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void LateUpdate () {
		hiascore.text = "Best Score :" + Sphere.hiscore;
	}
}
