using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
		if (other.gameObject.layer == LayerMask.GetMask ("Player")) {
			if (other.tag == "SqrPowerup") {
				GetComponent<LoadPlayer> ().changePlayer (Resources.Load ("/Assets/Resources/Prefabs/SqrPlayer", typeof(GameObject)));
				Destroy (other);
			} else if (other.tag == "TriPowerup") {
				GetComponent<LoadPlayer> ().changePlayer (Resources.Load ("/Assets/Resources/Prefabs/TriPlayer", typeof(GameObject)));
				Destroy (other);
			} else if (other.tag == "LifePowerup") {
				GetComponent<Health> ().addHealth (5);
				Destroy (other);
			}
		}
    }
}
