using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthCollider : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		print ("hfdsf");
	}
	void OnTriggerExit(Collider other)
	{
		print ("hfdsf");
	}

	void OnCollisionExit(Collision other)
	{
		print ("hfdsf");
	}
	void OnCollisionEnter(Collision other)
	{
		print("collision enter");
		transform.parent.parent.gameObject.GetComponent<noplate> ().dechealth (10);
	}
}
