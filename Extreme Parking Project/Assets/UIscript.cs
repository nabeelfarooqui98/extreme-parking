using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class UIscript : MonoBehaviour {

    public Button exit;
    public Button back;
    public Camera cam;
    
	// Use this for initialization
	void Start () {
        //Vector3 pL = new Vector3(40, 15, -97);  ///pl=parking lot
        //Vector3 pLrot = new Vector3(90, 90, 0);  ///angle in pL
        //Vector3 bul = new Vector3(57, 3, -20);  ///bul=building
        //Vector3 bulrot = new Vector3(175, 104, -176);   ///angle in bul

        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
   public void exitpressed()
    {
       
       GameObject.Find("ParkingDectector").GetComponent<checkparked>().enabled = false;
       GameObject.Find("Main Camera").GetComponent<followplayer>().enabled = false;
       
       GameObject cur_car = FindObjectOfType<instantiatecars>().getcurrentcar();
       cur_car.GetComponent<CarUserControl>().enabled = false;
       
       exit.gameObject.SetActive(false);
        cam.transform.position = new Vector3(40, 15, -97);
        cam.transform.eulerAngles = new Vector3(90, 90, 0);
        back.gameObject.SetActive(true);

    
             

    }
    public void backpressed()
    {
		FindObjectOfType<instantiatecars>().createcar();

        back.gameObject.SetActive(false);
        cam.transform.position = new Vector3(57, 3, -20);
        cam.transform.eulerAngles = new Vector3(0  , -90, 0);
	
		//cam.GetComponent<followplayer>().enabled = true;

	}

}
