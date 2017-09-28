using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class DeathSceneText : MonoBehaviour {

	public Canvas canvas;

	// Use this for initialization
	void Start () {
		canvas.transform.Find ("ScoreText").GetComponent<Text> ().text = "Score: " + ScoreManagement.Score.ToString();
		TimeSpan t = TimeSpan.FromSeconds (ScoreManagement.Time);
		canvas.transform.Find("TimeText").GetComponent<Text> ().text = "Time: " + string.Format ("{0:D2}:{1:D2}", t.Minutes, t.Seconds);
		canvas.transform.Find("AccuracyText").GetComponent<Text>().text = "Accuracy: " + ((ScoreManagement.BulletsHit / ScoreManagement.BulletsShot)*100).ToString()+"%";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
