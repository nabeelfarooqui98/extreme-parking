using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.Halo;

 
public class checkparked : MonoBehaviour {

	bool front=false;
	bool back =false;
    public Button exit;
	public Behaviour halo;	


	// Use this for initialization
	void Start () {
		halo.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (front && back) {
			print ("okok");
            exit.gameObject.SetActive(true);
            
			halo.enabled = false;
		} else {
			halo.enabled = true;
            exit.gameObject.SetActive(false);
		}
	}

	public void fronttrue()
	{
		front = true;
		print("frot true");
	}
	public void backtrue()
	{
		back = true;
	}

	public void frontfalse()
	{
		front = false;
		print("frot fas");
	}
	public void backfalse()
	{
		back = false;
	}

}
