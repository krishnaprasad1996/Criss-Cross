using UnityEngine;
using System.Collections;

public class rotateobj : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (5f, 5f, 5f * Time.deltaTime));
	
	}
}
