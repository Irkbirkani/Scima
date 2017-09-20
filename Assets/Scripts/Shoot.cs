using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    public Transform firePoint;
    public GameObject bullet;
    public float fireRate = 0.75f;


    private float lastShot = 0.0f;


	// Use this for initialization
	void Start () {
 
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0)&& Time.time > fireRate + lastShot)
        {
                Instantiate(bullet, firePoint.position, firePoint.rotation);
                lastShot = Time.time;       
        }
    }
}
