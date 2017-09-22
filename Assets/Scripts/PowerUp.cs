using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour {

    public string powerUp;
    public GameObject newPlayer;

    void OnTriggerEnter2d(Collider2D other)
    {
        Debug.Log("touch");
        if (other.gameObject.layer == LayerMask.GetMask("Player"))
        {
            Debug.Log("player touch");
            if (powerUp == "square")
            {
                GameObject.Find("Player").GetComponent<LoadPlayer>().changePlayer(newPlayer);
                Destroy(this);
            } else if (powerUp == "triangle")
            {
                GameObject.Find("Player").GetComponent<LoadPlayer>().changePlayer(newPlayer);
                Destroy(this);
            } else if (powerUp == "life")
            {
                other.GetComponent<Health>().addHealth(5);
                Destroy(this);
            }
        }
    }
}
