using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class noplate : MonoBehaviour {
    int myNum;
	int health=100;

	public Text healthText;
    void Start()
    {
        healthText = GameObject.Find("Health").GetComponent<Text>();
    }
    public void setNum(int n)
    {
        myNum = n;
    }
    public int getNum()
    {
        return myNum;
    }
	public int gethealth(){
		return health;
	}
	public void dechealth(int value){
		health -= value;
		healthText.text = health.ToString ();
	}


}

