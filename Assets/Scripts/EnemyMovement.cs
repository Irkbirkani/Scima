using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
    public float moveSpeed = 1f;
    private Transform target;
    private Rigidbody2D rigidbod;
    
	// Use this for initialization
	void Start () {

        rigidbod = GetComponent<Rigidbody2D>();
        target = GameObject.Find("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {

        
            if (Vector3.Distance(transform.position, target.position) > 1.25f)
            {
                Vector2 newVel = Vector3.Normalize(new Vector3(transform.position.x - target.position.x, transform.position.y - target.position.y, transform.position.z - target.position.z));
                rigidbod.AddForce((Random.value < 0.7) ? -newVel * moveSpeed : newVel * moveSpeed, ForceMode2D.Impulse);
            }
           
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "CircPlayer" || other.gameObject.tag == "SqrPlayer" || other.gameObject.tag == "TriPlayer")
        {
            other.gameObject.GetComponent<Health>().giveDamage(this.GetComponent<Health>().startHlth);
        }
    }
}
