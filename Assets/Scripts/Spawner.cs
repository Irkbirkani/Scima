using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    public GameObject enemy;
    public float delay = 3.0f;
    public bool active = true;

    
	// Use this for initialization
	void Start () {
        StartCoroutine(EnemyGenerator());
	}

    IEnumerator EnemyGenerator()
    {
        yield return new WaitForSeconds(delay);
        if (active)
        {
            var newTransform = new Vector2(transform.position.x + Random.Range(-5, 5), transform.position.y + Random.Range(-3, 3));

            Instantiate(enemy, newTransform, Quaternion.identity);
        }

        StartCoroutine(EnemyGenerator());
    }
}
