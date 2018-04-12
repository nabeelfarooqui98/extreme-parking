using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.UI;


public class TouchToControl : MonoBehaviour {

	RaycastHit hitInfo;
    public Button exit;
    public Button back;
	public Text carhealth;

	// Update is called once per frame
    void OnDisable()
    {
        if(back != null)
        back.gameObject.SetActive(false);
    }

	void Update () {

		if (Input.GetMouseButtonDown(0))
		{

			hitInfo = new RaycastHit();


			bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);
			if (hit && hitInfo.transform.gameObject.tag=="car") 
			{
				Debug.Log("Hit " + hitInfo.transform.gameObject.name);
				GetComponent<TouchToControl> ().enabled = false;
				GetComponent<followplayer> ().player = hitInfo.transform.gameObject;
				GetComponent<followplayer> ().enabled = true;
				hitInfo.transform.gameObject.GetComponent<CarUserControl> ().enabled = true;
				//carhealth.gameObject.SetActive(true);
				carhealth.text = hitInfo.transform.gameObject.GetComponent<noplate> ().gethealth ().ToString ();
                
                if (hitInfo.transform.position.z < -70)
                {
                    exit.gameObject.SetActive(true);
                }


			} else {
//				Debug.Log("No hit");
			}
//			Debug.Log("Mouse is down");
		}
			
	}

	public GameObject lastTouchedCarRef()
	{
		
		return hitInfo.transform.gameObject; 
	}

    public void test()
    {
        print("Button ");
        Debug.Log("ad");
    }
}
