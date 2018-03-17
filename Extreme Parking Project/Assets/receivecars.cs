using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class receivecars : MonoBehaviour
{
    public Button exit1;
    List<int> reqcars = new List<int>();

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider col)
    {

        if (col.name == "ColliderBottom")
        {
            
            //check jo mangi h wohi car h
            int garikano=col.GetComponentInParent<noplate>().getNum();
            
            print(FindObjectOfType<instantiatecars>().getReqCar());
            print(reqcars.Contains(garikano));
            if(reqcars.Contains(garikano))
              
           
                //if (col.GetComponentInParent<noplate>().getNum() == FindObjectOfType<instantiatecars>().getReqCar())

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



    public void updatelst(int car)
    {
        reqcars.Add(car);

       }
}