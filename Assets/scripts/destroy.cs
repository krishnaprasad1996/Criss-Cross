using UnityEngine;
using System.Collections;

public class destroy : MonoBehaviour {
	public GameObject player;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(0.29f,player.transform.position.y-7,0.29f);
	}
	void OnTriggerEnter(Collider other)
	{
		Destroy (other.gameObject);



	}
}
