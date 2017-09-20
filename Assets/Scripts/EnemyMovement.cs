using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
    public float moveSpeed = 1f;
    private Transform target;
    private Rigidbody2D rigidbod;
	private float timeTillPush = 0f;

	// Use this for initialization
	void Start () {

        rigidbod = GetComponent<Rigidbody2D>();
        target = GameObject.Find("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {

		timeTillPush -= Time.deltaTime;
		Vector2 newVel = Vector3.Normalize(new Vector3(transform.position.x - target.position.x, transform.position.y - target.position.y, transform.position.z - target.position.z));
            if (Vector3.Distance(transform.position, target.position) > 1.28f && timeTillPush <= 0)
            {
                rigidbod.AddForce(-newVel * moveSpeed, ForceMode2D.Impulse);
				timeTillPush = 1;
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
