using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followplayer : MonoBehaviour {

    public GameObject player;   ///har bar instantiate kr ne wala dena h func bana kr hojae ga baad ma dekhte hain 
    public Vector3 offset;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = player.transform.position+offset;
	}
}
