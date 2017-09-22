using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadPlayer : MonoBehaviour {

    public GameObject playerMode;

	// Use this for initialization
	void Start () {
        Instantiate(playerMode, transform.parent.position, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void changePlayer(GameObject newPlayer)
    {
        Destroy(GameObject.Find(playerMode.ToString()));
        playerMode = newPlayer;
        Instantiate(playerMode, transform.parent.position, transform.rotation);
    }
}
