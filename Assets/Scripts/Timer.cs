using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public static int time = 0;
    Text timer;

	// Use this for initialization
	void Start () {
        timer = GetComponent<Text>();
		
	}
	
	// Update is called once per frame
	void Update () {
        timer.text = "Timer: " + time/60;
        time++;
		
	}
}
