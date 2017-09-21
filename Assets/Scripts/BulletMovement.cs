﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour {

    public float speed;
    public int damage;

    private Rigidbody2D rigidBod;
	private GameObject playerType;
    private Vector3 difference;

    // Use this for initialization
    void Start () {
        rigidBod = GetComponent<Rigidbody2D>();
		playerType = GameObject.Find ("Player");
		if (playerType.GetComponent<LoadPlayer> ().playerMode.tag == "SqrPlayer") 
			difference = transform.position - playerType.GetComponent<LoadPlayer>().playerMode.transform.position;
		 else 
        	difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        difference.Normalize();
    }
	
	// Update is called once per frame
	void Update () {
        rigidBod.velocity = difference*speed;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Enemy")
        {
            float decAmount = 1f / (other.GetComponent<Health>().startHlth-1);
            other.GetComponent<SpriteRenderer>().color = new Color(other.GetComponent<SpriteRenderer>().color.r - decAmount, 0, 0);
            other.GetComponent<Health>().giveDamage(damage);
        }

        Destroy(gameObject);

    }
}
