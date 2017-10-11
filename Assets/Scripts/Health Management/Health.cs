using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour {

    public int health;
    public int startHlth;

    private Sprite sprite;

	void Awake(){
		if(tag=="TriPlayer" || tag == "CircPlayer" || tag == "SqrPlayer")
		{
			health = 40;
			startHlth = health;
		}
	}

	// Use this for initialization
	void Start () {
        sprite = GetComponent<SpriteRenderer>().sprite;
		if (tag != "TriPlayer" && tag != "CircPlayer" && tag != "SqrPlayer") {
			setHealth (sprite.name);
		}
    }
	
	// Update is called once per frame
	void Update () {
		if(health <= 0)
        {
            GameObject.Find("Arena").GetComponent<AudioSource>().Play();
            if (tag=="TriPlayer" || tag == "CircPlayer" || tag == "SqrPlayer")
            {
                Invoke("deathScene", 0.25f);
			} else if (tag == "Enemy" && this.isActiveAndEnabled)
            {
                GetComponent<DropPowerup>().dropPowerup();
				GameObject.Find ("Arena").transform.GetChild(1).gameObject.GetComponent<Spawner>().setInavtive(this.gameObject);
				ScoreManagement.Score += startHlth;
				ScoreManagement.BulletsHit += 1;
            }
        }
	}

    public void giveDamage(int dmg)
    {
        health -= dmg;
    }

    public void addHealth(int hlth)
    {
        int temp = health + hlth;
        health = (temp >= 40) ? 40 : temp;
    }
	public void setHealth(int hlth){
		health = hlth;
	}

	public void setHealth(string name){
		 if (name == "circle")
		{
			health = 2;
			startHlth = 2;
		}
		else if (name == "Triangle")
		{
			health = 3;
			startHlth = 3;
		}
		else if (name == "square")
		{
			health = 4;
			startHlth = 4;
		}
		else if (name == "Pentagon")
		{
			health = 5;
			startHlth = 5;
		}
		else if (name == "Hexagon")
		{
			health = 6;
			startHlth = 6;
		}
		else if (name == "Septagon")
		{
			health = 7;
			startHlth = 7;
		}
		else if (name == "Octogon")
		{
			health = 8;
			startHlth = 8;
		}
	}

    void deathScene()
    {
        SceneManager.LoadScene("DeathScene");
    }
}
