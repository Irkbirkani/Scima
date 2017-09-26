using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour {

	private GameObject enemy;

	private GameObject[] active;

	private GameObject[] inactive;



	public void createActive(Vector2 newPosition)
	{
		for (int i = 0; i <= 4; i++) 
		{
			if (inactive [i].activeSelf == false) 
			{
				GameObject newActive = getActive ();
				newActive = inactive [i];
				inactive [i].SetActive (true);
				newActive.SetActive (true);
				newActive.transform.position = newPosition;
			}
		}
	}

	GameObject getActive()
	{
		for (int i = 0; i <= 4; i++) 
		{
			if (active [i] == null)
				return active [i];
		}
		return null;
	}

	public void setInactive(){
		return;
	}
}
