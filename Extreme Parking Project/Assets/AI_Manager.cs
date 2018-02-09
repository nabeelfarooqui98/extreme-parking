using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityStandardAssets.Vehicles.Car;

public class AI_Manager : MonoBehaviour {
	
	CarAIControl ai;
	CarUserControl user;
	//CarController control;

	// Use this for initialization
	void Start () {
		user = GetComponent <CarUserControl>();
		ai = GetComponent <CarAIControl>();
		ai.SetTarget (GameObject.Find("AI_Target").transform);

		//control = car.GetComponent<CarController> ();

		user.enabled = false;
		ai.enabled = true;



	}

	// Update is called once per frame
	void Update () {
		if (!ai.isDriving() ) {

			user.enabled = true;
			ai.enabled = false;

		}
	}
}
