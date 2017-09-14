using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSelector : MonoBehaviour {
    public Sprite[] spriteList;

    private int maxSprite = 0;
    private float lastTime = 0.0f;

	// Use this for initialization
	void Start () {

        GetComponent<SpriteRenderer>().sprite = spriteList[Random.Range(0, maxSprite)];
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time - lastTime <= 10)
        {
            maxSprite = 0;
        } else if (Time.time - lastTime <= 20)
        {
            maxSprite = 1;
        }
        else if (Time.time - lastTime <= 30)
        {
            maxSprite = 2;
        }

    }
}
