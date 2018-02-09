using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiatecars : MonoBehaviour {

    public GameObject car1;
    public GameObject carcopy;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void createcar()
    {
        print("car is created");
        carcopy = (GameObject)Instantiate(car1,new Vector3(39.5f,0f,73f), Quaternion.Euler(0,180,0));
    }
}
