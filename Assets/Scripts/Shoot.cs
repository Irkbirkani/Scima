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
        if (Input.GetMouseButton(0) && Time.time > fireRate + lastShot)
        {
			if (tag == "SqrPlayer") {
				if (swap) {
					sqrBotShoot ();
					sqrTopShoot ();
                    //Invoke("sqrTopShoot",  0f);
                    //Invoke("sqrBotShoot",  0f);
                    //Invoke("sqrTopShoot",  0.25f);
					//Invoke("sqrBotShoot",  0.25f);
                    //Invoke("sqrTopShoot",  0.5f);
                    //Invoke("sqrBotShoot",  0.5f);
                    swap = !swap;
				} else {
                    //Invoke("sqrRightShoot", 0f);
                    //Invoke("sqrLeftShoot",  0f);
                    //Invoke("sqrRightShoot", 0.25f);
                    //Invoke("sqrLeftShoot",  0.25f);
                    //Invoke("sqrRightShoot", 0.5f);
                    //Invoke("sqrLeftShoot",  0.5f);
                    swap = !swap;
					lastShot = Time.time;
                }
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
