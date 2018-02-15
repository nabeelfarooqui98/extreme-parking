using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityStandardAssets.Vehicles.Car;

public class AI_Manager : MonoBehaviour
{

    CarAIControl ai;
    CarUserControl user;
    CarController control;
    bool userKoDeti = false;

    // Use this for initialization
    void Start()
    {
        user = GetComponent<CarUserControl>();
        ai = GetComponent<CarAIControl>();
        ai.SetTarget(GameObject.Find("AI_Target").transform);

        control = GetComponent<CarController>();

        user.enabled = false;
        ai.enabled = true;


    }

    // Update is called once per frame
    void Update()
    {
        if (!ai.isDriving())
        {

            ai.enabled = false;



            if (!userKoDeti)
            {
                control.Move(0, 0, 0, 1);
                print(control.CurrentSpeed);
                if (control.CurrentSpeed < 0.01)
                {
                    userKoDeti = true;
                    user.enabled = true;
                }



            }
        }

    }
}