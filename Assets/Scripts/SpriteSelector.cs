using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSelector : MonoBehaviour {
    public Sprite[] spriteList;

	// Use this for initialization
	void Start () {
        GetComponent<SpriteRenderer>().sprite = spriteList[Random.Range(0, spriteList.Length+1)];
	}
	
	// Update is called once per frame
	void Update () {

	}
}
