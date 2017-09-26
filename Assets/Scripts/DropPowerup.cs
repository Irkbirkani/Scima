using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropPowerup : MonoBehaviour {

    private GameObject powerUp;
    public GameObject[] powerUps;


	public void dropPowerup()	
    {
        if (Random.value > 0.8)
        {
            powerUp = Instantiate(powerUps[Random.Range(0, powerUps.Length)], transform.position, transform.rotation);
            Invoke("destroy", 3f);
        }
    }

    void destroy()
    {
        Destroy(powerUp);
    }
}
