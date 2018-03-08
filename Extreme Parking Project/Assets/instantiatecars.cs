using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class instantiatecars : MonoBehaviour {

    public GameObject []cars;
    GameObject carcopy;
	Camera cam;
    int numberofcars = 0;
	int reqcar =-1;

    List<GameObject> existingcars = new List<GameObject>();

    float last;
    float delay = 45f;

    // Use this for initialization
	void Start () {
        createcar();
        cam = Camera.main;
      
        last = Time.time; 
	}

    void Update()
    {
        
        while (Time.time > last + delay)
        {
            last = Time.time;

            print("time");
            askforcar();

        }
    }

    public void createcar()
    {

        int p = Random.Range(0, cars.Length);
        print("car is created");
        numberofcars++;
        carcopy = (GameObject)Instantiate(cars[p],new Vector3(39.5f,0f,73f), Quaternion.Euler(0,180,0));
        carcopy.GetComponent<noplate>().setNum(numberofcars);
        print(numberofcars);
        existingcars.Add(carcopy);
    }
    public GameObject getcurrentcar()
    {
        return carcopy;
    }
    public int  getnumberofcars()
    {
        return numberofcars;
    }

    ////return car 
    public void askforcar()
    {
        reqcar = Random.Range(1, numberofcars+1);
		print ("asking for car num: " + reqcar);
        for (int i = 0; i < numberofcars; i++)
        {
            if (existingcars[i].GetComponent<noplate>().getNum() == reqcar)
            {
               
                Behaviour halo = (Behaviour)existingcars[i].GetComponent("Halo");
                halo.enabled = true; // false
				return;
            }
        }

		askforcar ();
            
    }
    public int getReqCar()
    {
        return reqcar;
    }




}   
