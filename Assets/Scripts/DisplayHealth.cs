using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayHealth : MonoBehaviour {

    public Text healthText;
    private string health;

	// Use this for initialization
	void Start () {
        health = GetComponent<Health>().health.ToString();
        healthText.text = health;
	}
	
	// Update is called once per frame
	void Update () {
        health = GetComponent<Health>().health.ToString();
        healthText.text = health;
    }
}
