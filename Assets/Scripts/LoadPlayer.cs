using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadPlayer : MonoBehaviour {

    public GameObject playerMode;

	// Use this for initialization
	void Start () {
        Instantiate(playerMode);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
