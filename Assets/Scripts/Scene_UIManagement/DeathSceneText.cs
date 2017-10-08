using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class DeathSceneText : MonoBehaviour {

	public Canvas canvas;

	// Use this for initialization
	void Start () {
        if (ScoreManagement.Time > ScoreManagement.LongestTime)
            ScoreManagement.LongestTime = ScoreManagement.Time;
        if (ScoreManagement.Score > ScoreManagement.HighScore)
            ScoreManagement.HighScore = ScoreManagement.Score;
		canvas.transform.Find ("ScoreText").GetComponent<Text> ().text = "Score: " + ScoreManagement.Score.ToString();
        canvas.transform.Find("HighScoreText").GetComponent<Text>().text = "High Score: " + ScoreManagement.HighScore.ToString();
        TimeSpan t = TimeSpan.FromSeconds (ScoreManagement.Time);
		canvas.transform.Find("TimeText").GetComponent<Text> ().text = "Time: " + string.Format ("{0:D2}:{1:D2}", t.Minutes, t.Seconds);
        TimeSpan t2 = TimeSpan.FromSeconds(ScoreManagement.Time);
        canvas.transform.Find("LongestTimeText").GetComponent<Text>().text = "Longest Time: " + string.Format("{0:D2}:{1:D2}", t2.Minutes, t2.Seconds);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
