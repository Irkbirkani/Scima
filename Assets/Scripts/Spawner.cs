using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    public GameObject enemy;
    public float delay = 3.0f;
    public bool active = true;
    public Sprite[] spriteList;

    private int maxSprite = 0;
    private int minSprite = 0;
    private float lastTime = 0.0f;


    // Use this for initialization
    void Start () {
        
        StartCoroutine(EnemyGenerator());
	}

    IEnumerator EnemyGenerator()
    {
        yield return new WaitForSeconds(delay);
        if (active)
        {

            Vector2 newTransform = new Vector2(transform.position.x + Random.Range(-5, 5), transform.position.y + Random.Range(-3, 3));
           
            enemy.GetComponent<SpriteRenderer>().sprite = spriteList[Random.Range(minSprite, maxSprite)];
            Instantiate(enemy, newTransform, Quaternion.identity);
        }

        StartCoroutine(EnemyGenerator());
    }

    void Update()
    {
        if (Time.time - lastTime <= 15)
        {
            maxSprite = 0;
        }
        else if (Time.time - lastTime <= 30)
        {
            maxSprite = 2;
            delay = 2.5f;
        }
        else if (Time.time - lastTime <= 40)
        {
            maxSprite = 5;
        }
        else if (Time.time - lastTime <= 50)
        {
            maxSprite = 9;
        }
        else if (Time.time - lastTime <= 60)
        {
            maxSprite = 14;
            minSprite = 1;
            delay = 2f;
        }
        else if (Time.time - lastTime <= 70)
        {
            maxSprite = 20;
            minSprite = 1;
        }
        else if (Time.time - lastTime <= 80)
        {
            maxSprite = 27;
            minSprite = 2;
        }
        else if (Time.time - lastTime <= 90)
        {
            maxSprite = 27;
            minSprite = 5;
            delay = 1.5f;
        }
        else if (Time.time - lastTime <= 100)
        {
            maxSprite = 27;
            minSprite = 9;
        }
        else if (Time.time - lastTime <= 110)
        {
            maxSprite = 27;
            minSprite = 14;
        }
        else if (Time.time - lastTime <= 120)
        {
            maxSprite = 27;
            minSprite = 20;
            delay = 1f;
        }
        else if (Time.time - lastTime <= 130)
        {
            maxSprite = 27;
            minSprite = 27;
        }
    }
}
