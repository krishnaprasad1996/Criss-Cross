using UnityEngine;
using System.Collections;

public class lights : MonoBehaviour {
	public GameObject lightl;
	public GameObject lightr;
	public GameObject player;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		lightl.transform.position = new Vector3 (5.81f, player.transform.position.y, -4.87f);
		lightr.transform.position = new Vector3 (-6.1f, player.transform.position.y, -4.87f);

	}
}
