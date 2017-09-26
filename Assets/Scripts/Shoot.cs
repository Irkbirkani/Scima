using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    public Transform[] firePoint;
    public GameObject bullet;
    public float fireRate = 0.75f;


    private float lastShot = 0.0f;
	private bool swap = true;



	// Use this for initialization
	void Start () {
 
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (0) && Time.time > fireRate + lastShot) {
			if (tag == "SqrPlayer") {
				sqrBotShoot ();
				sqrTopShoot ();
				sqrRightShoot ();
				sqrLeftShoot ();
				lastShot = Time.time;
			} else {
				Instantiate (bullet, firePoint[0].position, firePoint[0].rotation);
				lastShot = Time.time;       
			}
        }
    }

	void sqrTopShoot(){
		Instantiate (bullet, firePoint [0].position, firePoint [0].rotation);
	}
	void sqrRightShoot(){
		Instantiate (bullet, firePoint [1].position, firePoint [1].rotation);
	}

	void sqrBotShoot(){
		Instantiate (bullet, firePoint [2].position, firePoint [2].rotation);
	}

	void sqrLeftShoot(){
		Instantiate (bullet, firePoint [3].position, firePoint [3].rotation);
	}
		
}
