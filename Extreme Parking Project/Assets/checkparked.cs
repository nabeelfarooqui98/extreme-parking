using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.Halo;

 
public class checkparked : MonoBehaviour {

	bool bigBool=false;
	bool front=false;
	bool back =false;
    public Button exit;
	public Behaviour halo;
	//bool userscript=false;


	// Use this for initialization
	void Start () {
		//halo.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		/*if (front && back) {
			print ("okok");
            exit.gameObject.SetActive(true);
            
			halo.enabled = false;
		} else {
			halo.enabled = true;
            exit.gameObject.SetActive(false);
		}*/
/*		if (bigBool ) {
			exit.gameObject.SetActive(true);
		} else {
				exit.gameObject.SetActive(false);
	}
*/
	}

	public void fronttrue()
	{
		front = true;
//		print("frot true");
	}
	public void backtrue()
	{
		back = true;
	}

	public void frontfalse()
	{
		front = false;
//		print("frot fas");
	}
	public void backfalse()
	{
		back = false;
	}
	public void bigTrue()
	{
		bigBool = true;
	}
	public void bigFalse()
	{
		bigBool = false;
	}



}
