using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bigCol : MonoBehaviour {
	public Button exit;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.name == "ColliderBottom") {
			exit.gameObject.SetActive(true);
			gameObject.GetComponentInParent<checkparked> ().bigTrue ();
		}	
	}
	void OnTriggerExit(Collider col)
	{
		if (col.name == "ColliderBottom") 
		{
			exit.gameObject.SetActive(false);
			gameObject.GetComponentInParent<checkparked> ().bigFalse ();

		}
	}
}
