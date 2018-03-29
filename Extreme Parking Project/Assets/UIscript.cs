using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class UIscript : MonoBehaviour {

    public Button exit;
    public Button back;
	public Button plot;
	public Button start;
	public Button exit1;
    public Camera cam;

	public Text scoreText;
	public Text timeText;
	public Text carhealth;
    
	int timeLeft;
	int delay = 1;
	float last;

	int score;

	// Use this for initialization
	void Start () {
		timeLeft = 150;
		score = 0;
		last =Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		timeText.text = timeLeft.ToString ();

		if (Time.time > last + delay) {
			last = Time.time;
			timeLeft--;

		}
	}


   public void exitpressed()
    {
       
       //GameObject.Find("ParkingDectector").GetComponent<checkparked>().enabled = false;
       GameObject.Find("Main Camera").GetComponent<followplayer>().enabled = false;
		GameObject.Find("Main Camera").GetComponent<TouchToControl>().enabled = true;

		GameObject cur_car =  Camera.main.GetComponent<TouchToControl>().lastTouchedCarRef();//FindObjectOfType<instantiatecars>().getcurrentcar();
       cur_car.GetComponent<CarUserControl>().enabled = false;

		carhealth.gameObject.SetActive (false);
       exit.gameObject.SetActive(false);
        cam.transform.position = new Vector3(40, 15, -97);
        cam.transform.eulerAngles = new Vector3(90, 90, 0);
        back.gameObject.SetActive(true);

    
             

    }
    public void backpressed()
    {
		print ("back pressed");
		FindObjectOfType<instantiatecars>().createcar();
		Camera.main.GetComponent<TouchToControl> ().enabled = true;
        back.gameObject.SetActive(false);
        cam.transform.position = new Vector3(57, 3, -20);
        cam.transform.eulerAngles = new Vector3(0  , -90, 0);
	

	}
	public void Dropoff(){
		exit1.gameObject.SetActive(false);
		carhealth.gameObject.SetActive (false);
		GameObject.Find("Main Camera").GetComponent<followplayer>().enabled = false;
		GameObject.Find("Main Camera").GetComponent<TouchToControl>().enabled = true;
		GameObject cur_car =  Camera.main.GetComponent<TouchToControl>().lastTouchedCarRef();
        int x= cur_car.GetComponent<noplate>().getNum();
        instantiatecars y=GameObject.Find("CarMaker").GetComponent<instantiatecars>();
        y.deleteno(x);
        y.deleteexitscar(cur_car);
        Destroy (cur_car);
		start.gameObject.SetActive(true);
		plot.gameObject.SetActive(true);
		score++;
		scoreText.text = score.ToString ();
	}

	public void gotoplot(){
		start.gameObject.SetActive(false);
		plot.gameObject.SetActive(false);
        back.gameObject.SetActive(true);
		cam.transform.position = new Vector3(40, 15, -97);
		cam.transform.eulerAngles = new Vector3(90, 90, 0);


	}

	public void gotostart(){
		start.gameObject.SetActive(false);
		plot.gameObject.SetActive(false);
        FindObjectOfType<instantiatecars>().createcar();
        Camera.main.GetComponent<TouchToControl>().enabled = true;

		cam.transform.position = new Vector3(57, 3, -20);
		cam.transform.eulerAngles = new Vector3(0  , -90, 0);


	}


}
