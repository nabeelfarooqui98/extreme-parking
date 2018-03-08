using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class receivecars : MonoBehaviour {
    public Button exit1;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider col)
    {
      
        if (col.name == "ColliderBottom")
        {
            //check jo mangi h wohi car h
           
            print(FindObjectOfType<instantiatecars>().getReqCar());
            if (col.GetComponentInParent<noplate>().getNum() == FindObjectOfType<instantiatecars>().getReqCar())
            exit1.gameObject.SetActive(true);
            //AI on krni h if exit is pressed 
     
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.name == "ColliderBottom")
        {
            exit1.gameObject.SetActive(false);
     

        }
    }
}
