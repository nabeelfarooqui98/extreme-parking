using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class TouchToControl : MonoBehaviour {

	RaycastHit hitInfo;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown(0))
		{
//			Debug.Log("Mouse is down");



			hitInfo = new RaycastHit();


			bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);
			if (hit) 
			{
				Debug.Log("Hit " + hitInfo.transform.gameObject.name);
				GetComponent<TouchToControl> ().enabled = false;
				GetComponent<followplayer> ().player = hitInfo.transform.gameObject;
				GetComponent<followplayer> ().enabled = true;
				hitInfo.transform.gameObject.GetComponent<CarUserControl> ().enabled = true;

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
