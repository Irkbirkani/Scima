using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;

public class TimeManager : MonoBehaviour {

    public Text scoreText;

    private float timeElapsed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timeElapsed += Time.deltaTime;
        scoreText.text = FormatTime(timeElapsed);
	}

    string FormatTime(float value)
    {
        TimeSpan t = TimeSpan.FromSeconds(value);
        return string.Format("{0:D2}:{1:D2}", t.Minutes, t.Seconds);
    }
}
