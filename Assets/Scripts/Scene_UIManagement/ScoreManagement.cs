using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ScoreManagement {
	
	private static int score, highscore,bulletsShot, bulletsHit;
	private static float accuracy, totaccuracy, time, longestTime;

	public static int Score
	{
		get 
		{
			return score;
		}

		set
		{
			score = value;
		}
	}

	public static int HighScore
	{
		get
		{
			return highscore;
		}

		set
		{
			highscore = value;
		}
	}

	public static int BulletsShot
	{
		get 
		{
			return bulletsShot;
		}
		set 
		{
			bulletsShot = value;
		}
	}

	public static int BulletsHit
	{
		get 
		{
			return bulletsHit;
		}
		set 
		{
			bulletsHit = value;
		}
	}

	public static float Accuracy
	{
		get 
		{
			return accuracy;
		}

		set 
		{
			accuracy = value;
		}
	}

	public static float TotalAccuracy
	{
		get 
		{
			return totaccuracy;
		}

		set 
		{
			totaccuracy = value;
		}
	}

	public static float Time
	{
		get 
		{
			return time;
		}

		set 
		{
			time = value;
		}
	}

	public static float LongestTime
	{
		get 
		{
			return longestTime;
		}

		set 
		{
			longestTime = value;
		}
	}
}
