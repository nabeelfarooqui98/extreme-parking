using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityStandardAssets.Vehicles.Car;

public class carEnter : MonoBehaviour {

	public GameObject car;
	CarAIControl ai;
	CarUserControl user;
	CarController control;

	// Use this for initialization
	void Start () {
		user = car.GetComponent <CarUserControl>();
		ai = car.GetComponent <CarAIControl>();
		control = car.GetComponent<CarController> ();

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
