using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    public Transform[] firePoint;
    public GameObject bullet;
    public float fireRate = 0.75f;

    private AudioSource shot;
	private bool superFire = false;
    private float lastShot = 0.0f;

	// Use this for initialization
	void Start () {
        shot = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (0) && Time.time > fireRate + lastShot && !superFire) {
            shot.Play();
			if (tag == "SqrPlayer") {
				multiShoot (0,4);
				lastShot = Time.time;
			} else {
				singleShoot ();
				lastShot = Time.time;
			}
			ScoreManagement.BulletsShot += 1;
		} else if (Input.GetMouseButton (0) && Time.time > fireRate + lastShot && superFire) {
            shot.Play();
            if (tag == "SqrPlayer") {
				multiShoot (0, 8);
				lastShot = Time.time;
			} else if (tag == "CircPlayer") {
				multiShoot (1, 3);
				lastShot = Time.time;
			} else if (tag == "TriPlayer") {
				singleShoot ();
				Invoke ("singleShoot", 0.25f);
				lastShot = Time.time;
			}
			ScoreManagement.BulletsShot += 1;
		}
    }

	void multiShoot(int startIndex, int maxIndex){
		for (int i = startIndex; i < maxIndex; i++) {
			Instantiate (bullet, firePoint [i].position, firePoint [i].rotation);
		}
	}

	void singleShoot(){
		Instantiate (bullet, firePoint [0].position, firePoint [0].rotation);
	}

	public void SuperFirePoint()
	{
		CancelInvoke ();
		superFire = true;
		Invoke("ResetFirePoint", 15f);
	}

	void ResetFirePoint(){
		superFire = false;
	}
}
