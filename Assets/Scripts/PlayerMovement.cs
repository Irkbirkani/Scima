using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float moveSpeed = 3f;
    public float offset = 0.0f;
    private Rigidbody2D rigidbod;

    // Use this for initialization
    void Start () {
        rigidbod = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        float inX = Input.GetAxis("Horizontal");
        float inY = Input.GetAxis("Vertical");
       
        rigidbod.velocity = new Vector2(inX * moveSpeed, inY * moveSpeed);

        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        difference.Normalize();
        float rotation_z = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotation_z + offset);
    }
}
