using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carMov : MonoBehaviour {

	public GameObject player;
	public Rigidbody playerRigid;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.UpArrow)) {
			if (playerRigid.velocity.magnitude < 10) {
                playerRigid.AddForce(0,0, 500 * Time.deltaTime); //for local forward
			}

		}
        if (Input.GetKey(KeyCode.UpArrow))
        {

            playerRigid.AddForce(0, 0,-500 * Time.deltaTime); //for local forward
        }
		if (Input.GetKey (KeyCode.RightArrow)) {
			player.transform.Rotate (0, 2, 0);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			player.transform.Rotate (0, -2, 0);
		}

	}
}
