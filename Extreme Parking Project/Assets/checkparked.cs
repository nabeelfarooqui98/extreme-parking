using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Halo;

 
public class checkparked : MonoBehaviour {

	bool front=false;
	bool back =false;

	public Behaviour halo;	


	// Use this for initialization
	void Start () {
		halo.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (front && back) {
			print ("okok");
			halo.enabled = false;
		} else {
			halo.enabled = true;
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
