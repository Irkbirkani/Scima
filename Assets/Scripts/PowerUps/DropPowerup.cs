using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropPowerup : MonoBehaviour {

    private GameObject powerUp;
    public GameObject[] powerUps;
    public float dropPercent = 0.8f;

	public void dropPowerup()	
    {
        if (Random.value > dropPercent)
        {
            powerUp = Instantiate(powerUps[Random.Range(0, powerUps.Length)], transform.position, transform.rotation);
            Invoke("destroy", 6f);
        }
    }

    void destroy()
    {
        Destroy(powerUp.gameObject);
    }
}
