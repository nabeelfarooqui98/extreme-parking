using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frontCOL : MonoBehaviour {

//	bool touch;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.name == "ColliderBottom") {
			gameObject.GetComponentInParent<checkparked> ().fronttrue ();
		}	

	}
	void OnTriggerExit(Collider col)
	{
		if (col.name == "ColliderBottom") 
			{
				gameObject.GetComponentInParent<checkparked> ().frontfalse ();

			}
	}

}
