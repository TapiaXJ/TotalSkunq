using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour {

    public float timeLeft = 300;
    public Text timerTextBox; 

    public Sprite gameOver;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timeLeft -= Time.deltaTime;

        if(timeLeft<0)
        {
            
        }
	}
}
