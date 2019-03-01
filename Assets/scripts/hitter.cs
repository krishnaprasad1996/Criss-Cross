using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class hitter : MonoBehaviour {
	private Sphere instance_sp;
	public GameObject player;
	public GameObject game;
	public GameObject res;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position=new Vector3 (-0.01f, player.transform.position.y - 5f, 0f);

	}

	void OnTriggerEnter(Collider other)
	{
		if ((other.gameObject.CompareTag ("pick_up"))||(other.gameObject.CompareTag("lose"))) {
			player.gameObject.SetActive (false);
			game.SetActive (false);
			res.SetActive (true);
			//SceneManager.LoadScene ("restart");
			instance_sp = GameObject.FindObjectOfType (typeof(Sphere)) as Sphere;
			Sphere.hiascore (Sphere.score);

		}

	}
}
