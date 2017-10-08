using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MonoBehaviour {

    private Rigidbody2D bod;
    private float timeTillPush = 0f;

	// Use this for initialization
	void Start () {
        bod = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        timeTillPush -= Time.deltaTime;
        if (timeTillPush <= 0)
        {
            bod.AddForce(new Vector2(Random.Range(-1, 2), Random.Range(-1, 2)), ForceMode2D.Impulse);
            timeTillPush = 1f;
        }
	}
}
