using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {
	public GameObject player;
	private Vector3 offset;
	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(0.3f,player.transform.position.y,-10f);
	}
}
