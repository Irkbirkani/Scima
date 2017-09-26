using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour {

	private GameObject enemy;

	private GameObject[] active;

	private GameObject[] inactive;

	public ObjectPool(GameObject _enemy) 
	{
		enemy = _enemy;
		active = new GameObject[5];
		inactive = new GameObject[5] {
			enemy.SetActive (false),
			enemy.SetActive (false),
			enemy.SetActive (false),
			enemy.SetActive (false),
			enemy.SetActive (false)
		};
	}

	public void createActive()
	{
		for (int i = 0; i <= 4; i++) 
		{
			if (inactive [i].activeSelf == false) 
			{
				GameObject newActive = getActive () = inactive [i];

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
	}
}
