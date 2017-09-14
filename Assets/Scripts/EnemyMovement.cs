using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
    public float moveSpeed = 2f;
    private Transform target;
    private Rigidbody2D rigidbod;
    
	// Use this for initialization
	void Start () {
        rigidbod = GetComponent<Rigidbody2D>();
        target = GameObject.Find("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
        //transform.LookAt(target.transform.position);
        //transform.Rotate(new Vector3(0, -90, -90), Space.Self);
        if (Vector3.Distance(transform.position, target.position) > 1.25f)
        {
            Vector2 newVel = Vector3.Normalize(new Vector3(transform.position.x - target.position.x, transform.position.y - target.position.y, transform.position.z - target.position.z));
            rigidbod.velocity = -newVel * moveSpeed;
        }
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            other.GetComponent<Health>().giveDamage(this.GetComponent<Health>().startHlth);
            rigidbod.velocity = -rigidbod.velocity;
        }
    }
}
