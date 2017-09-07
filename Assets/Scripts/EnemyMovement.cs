using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
    public float moveSpeed = 2f;
    public GameObject target = GameObject.FindWithTag("Player");
    private Rigidbody2D rigidbod;
    
	// Use this for initialization
	void Start () {
       rigidbod = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(target.transform.position);
        transform.Rotate(new Vector3(0, -90, -90), Space.Self);
        if (Vector3.Distance(transform.position, target.transform.position) > 1.25f)
        {
            Vector2 newVel = Vector3.Normalize(new Vector3(transform.position.x - target.transform.position.x, transform.position.y - target.transform.position.y, transform.position.z - target.transform.position.z));
            rigidbod.velocity = -newVel * moveSpeed;
        }
	}
}
