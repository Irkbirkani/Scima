using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
    public float moveSpeed = 1f;
    private GameObject targetParent;
    private Transform target;
    private Rigidbody2D rigidbod;
	private float timeTillPush = 0f;

	// Use this for initialization
	void Start () {

        rigidbod = GetComponent<Rigidbody2D>();
        targetParent = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
        for (int i = 0; i < targetParent.transform.childCount; i++)
        {
            if (targetParent.transform.GetChild(i).gameObject.activeSelf == true)
                target = targetParent.transform.GetChild(i);
        }

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
			GameObject.Find ("Player").GetComponent<LoadPlayer> ().giveAllDamage (this.GetComponent<Health> ().startHlth);
            GetComponent<Health>().giveDamage(GameObject.Find("Player").GetComponent<LoadPlayer>().giveDamage());
            float decAmount = 1f / (GetComponent<Health>().startHlth - 1);
            GetComponent<SpriteRenderer>().color = new Color(GetComponent<SpriteRenderer>().color.r - decAmount, 0, 0);
            GetComponent<AudioSource>().Play();
        }
    }
}
