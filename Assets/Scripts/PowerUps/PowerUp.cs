using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour {
    void OnTriggerEnter2D(Collider2D other)
    {
		if (other.gameObject.layer == 9) {
			if (other.tag == "SqrPowerup") {
                other.GetComponent<AudioSource>().Play();
                other.transform.position = new Vector2(1000, 1000);
				transform.parent.GetComponent<LoadPlayer>().startChangePlayer(1);
			} else if (other.tag == "TriPowerup") {
                other.GetComponent<AudioSource>().Play();
                other.transform.position = new Vector2(1000, 1000);
                transform.parent.GetComponent<LoadPlayer>().startChangePlayer(2);
			} else if (other.tag == "LifePowerup") {
                other.GetComponent<AudioSource>().Play();
                other.transform.position = new Vector2(1000, 1000);
                GameObject.Find("Player").GetComponent<LoadPlayer>().giveAllHealth(5);
            } else if (other.tag == "BulletPowerup") {
                other.GetComponent<AudioSource>().Play();
                other.transform.position = new Vector2(1000, 1000);
                GetComponent<Shoot>().SuperFirePoint();
			}
		}
    }
}
