using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    public int health;

    public int startHlth;
    private Sprite sprite;

	// Use this for initialization
	void Start () {
        sprite = GetComponent<SpriteRenderer>().sprite;
		if (gameObject.tag == "Player")
        {
            health = 40;
        }
        else if (sprite.name == "circle")
        {
            health = 2;
            startHlth = 2;
        }
        else if (sprite.name == "Triangle")
        {
            health = 3;
            startHlth = 3;
        }
        else if (sprite.name == "square")
        {
            health = 4;
            startHlth = 4;
        }
        else if (sprite.name == "Pentagon")
        {
            health = 5;
            startHlth = 5;
        }
        else if (sprite.name == "Hexagon")
        {
            health = 6;
            startHlth = 6;
        }
        else if (sprite.name == "Septagon")
        {
            health = 7;
            startHlth = 7;
        }
        else if (sprite.name == "Octogon")
        {
            health = 8;
            startHlth = 8;
        }
    }
	
	// Update is called once per frame
	void Update () {
		if(health <= 0)
        {
            Destroy(gameObject);
        }
	}

    public void giveDamage(int dmg)
    {
        health -= dmg;
    }
}
