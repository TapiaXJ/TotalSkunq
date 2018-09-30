using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour {

    public float timeLeft = 300;
    public Text text; 

    public Sprite gameOver;

	// Use this for initialization
	void Start () {
//        text = GameObject.FindWithTag("timer");
//        text = GetComponent<Text>;
		
	}
	
	// Update is called once per frame
	void Update () {
        timeLeft -= Time.deltaTime;
        text.text = Mathf.Round(timeLeft).ToString();

        if(timeLeft<0)
        {
            
        }
	}
}
