using UnityEngine;
using System.Collections;

public class raycast : MonoBehaviour {
	private Sphere instance_sp;
    private redsphere instance_red;
	public GameObject player;
	private Vector3 offset;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(-3.0f,player.transform.position.y,0f);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("gen")) {
			instance_sp = GameObject.FindObjectOfType (typeof(Sphere)) as Sphere;
            instance_red = GameObject.FindObjectOfType(typeof(redsphere)) as redsphere;
			instance_sp.generate ();
			if (instance_sp.move_speed < 10) {
				instance_sp.move_speed += 0.2f;
                instance_red.move_speed += 0.2f;
			}
		}
		


	}
}
