using UnityEngine;
using System.Collections;

public class redsphere : MonoBehaviour {
    public float move_speed;

    public static int score;
    public GameObject player;

    public GameObject game;
    public GameObject res;
    private Rigidbody rigid_body;
    private float i = 0f;

    public static int hiscore;
    public GameObject win_cube;
    public GameObject lose_cube;

	// Use this for initialization
	void Start () {
        rigid_body = gameObject.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.anyKeyDown)
        {

            if (i % 2 == 0)
            {
                Vector3 dir_l = Quaternion.AngleAxis(135f, Vector3.forward) * Vector3.right;
                rigid_body.velocity = dir_l * move_speed;

                i++;
               
            }
            else
            {
                Vector3 dir_r = Quaternion.AngleAxis(45f, Vector3.forward) * Vector3.right;
                rigid_body.velocity = dir_r * move_speed;


                i++;

              
            }
        }
	}
        void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("pick_up")) {
            player.SetActive(false);
            game.SetActive(false);
            res.SetActive(true);
            //SceneManager.LoadScene ("restart");
           
			Destroy (other.gameObject);


			score=score+1;


		}
		if(other.gameObject.CompareTag("lose")){
            Destroy(other.gameObject);


            score = score + 1;
			
		}

		
	}
}
