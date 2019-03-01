using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Random=UnityEngine.Random;
using UnityEngine.SceneManagement;

public class Sphere : MonoBehaviour {
	
	public float move_speed;
	public GameObject left_wall;
	public static int score;
	public GameObject player;
	public GameObject right_wall;
	public GameObject game;
	public GameObject res;
	public Text scoretext;
    private Rigidbody rigid_body;
	private float i = 0f,x_l=-3.0f,y_l=1f,z_l=0f,x_r=3.5f,y_r=1f,z_r=0f;
	private Vector3 vec,vec1;
	public static int hiscore;
	public GameObject win_cube;
	public GameObject lose_cube;
  

	// Use this for initialization
	void Start () {
  
    
        
         rigid_body = gameObject.GetComponent <Rigidbody>();
		generate ();
		score = 0;
      }
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKeyDown) {
			scoretext.text = score.ToString();
			if (i % 2 == 0) {
				Vector3 dir_r = Quaternion.AngleAxis (45f, Vector3.forward) * Vector3.right;
				rigid_body.velocity=dir_r*move_speed;


				i++;
			} else {
				Vector3 dir_l = Quaternion.AngleAxis (135f, Vector3.forward) * Vector3.right;
				rigid_body.velocity=dir_l*move_speed;

				i++;
			}
			
		}

	}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("pick_up")) {
			Destroy (other.gameObject);


			score=score+1;


		}
        if ((other.gameObject.CompareTag("lose")) || (other.gameObject.CompareTag("tetra")))
        {
			player.SetActive(false);
			game.SetActive (false);
			res.SetActive (true);
			//SceneManager.LoadScene ("restart");
			hiascore (score);
		}

		
	}


	public void generate()
	{


		for (int j = 0; j < 20; j++) {
			GameObject left= Instantiate (left_wall, GameObject.FindGameObjectWithTag("left_pos").transform.position, Quaternion.identity) as GameObject;
			Instantiate (right_wall, GameObject.FindGameObjectWithTag("right_pos").transform.position, Quaternion.identity);
			if (j == 7) {
				left.tag = "gen";
			} else {
				left.tag = "dest";}
			if (j % 6== 0) {
				if (j == 0 || j == 1 || j == 2) {
				} else {
					int random_color = Random.Range (0, 4);
					float random_place = Random.Range (-1.7f, 2.0f);					if (random_color <3 ) {
						Instantiate (win_cube,new Vector3(random_place,y_l,z_l), Quaternion.identity);
					} else {
						Instantiate (lose_cube,new Vector3(random_place,y_l,z_l), Quaternion.identity);
					}

				}

			}

			y_l += 0.7f;
			y_r += 0.7f;
			left_wall.transform.position = new Vector3 (x_l,y_l, z_l);
			right_wall.transform.position = new Vector3 (x_r,y_r, z_r);

		}

	}
	public static void hiascore(int score1)
	{ hiscore = PlayerPrefs.GetInt ("hiscore1",0);
		
		if (score > hiscore) {
			PlayerPrefs.SetInt ("hiscore1", score1);
		}
	}
}
