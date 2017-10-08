using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadPlayer : MonoBehaviour {

    public GameObject[] playerModes;
    public int defaultPlayerMode;

    private GameObject circPlayer;
    private GameObject sqrPlayer;
    private GameObject triPlayer;
    private GameObject[] players;
    private int currPlayer = 0;
    private int tempPlayer;

    // Use this for initialization
    void Start () {
        circPlayer = Instantiate(playerModes[defaultPlayerMode], transform.position, Quaternion.identity);
        circPlayer.transform.parent = transform;

        sqrPlayer = Instantiate(playerModes[1], transform.position, Quaternion.identity);
        sqrPlayer.transform.parent = transform;
        sqrPlayer.SetActive(false);

        triPlayer = Instantiate(playerModes[2], transform.position, Quaternion.identity);
        triPlayer.transform.parent = transform;
        triPlayer.SetActive(false);

        players = new GameObject[3] { circPlayer, sqrPlayer, triPlayer };
    }

    void Update()
    {
       if(currPlayer == 0)
        {
            players[1].transform.position = players[currPlayer].transform.position;
            players[2].transform.position = players[currPlayer].transform.position;
        }
        else if ( currPlayer == 1)
        {
            players[0].transform.position = players[currPlayer].transform.position;
            players[2].transform.position = players[currPlayer].transform.position;
        }
        else if (currPlayer == 2)
        {
            players[0].transform.position = players[currPlayer].transform.position;
            players[1].transform.position = players[currPlayer].transform.position;
        }
    }


    public void startChangePlayer(int newPlayer)
    {
        Animate(newPlayer);
        tempPlayer = newPlayer;
        Invoke("finishChangePlayer", 0.5f);
    }
    void finishChangePlayer()
    {
        int hlth = players[currPlayer].GetComponent<Health>().health;
        players[currPlayer].SetActive(false);
        currPlayer = tempPlayer;
        players[currPlayer].SetActive(true);
        players[currPlayer].GetComponent<Health>().health = hlth;
        CancelInvoke();
        Invoke("resetPlayer", 15);
    }

    void resetPlayer()
    {
        players[currPlayer].GetComponent<Animator>().SetBool("CircAnim", true);
        GetComponent<AudioSource>().Play();
        Invoke("reset", 1);
    }
    void reset()
    {
        players[currPlayer].SetActive(false);
        currPlayer = 0;
        players[currPlayer].SetActive(true);
    }

	public void giveAllDamage(int dmg)
	{
		for (int i = 0; i < 3; i++) 
		{
			players [i].GetComponent<Health> ().giveDamage (dmg);
		}
	}

    public void giveAllHealth(int hlth)
    {
        for (int i = 0; i < 3; i++)
        {
            players[i].GetComponent<Health>().addHealth(hlth);
        }
    }

    void Animate(int newPlayer)
    {
        if (newPlayer == 2)
            players[currPlayer].GetComponent<Animator>().SetBool("TriAnim", true);
        else if (newPlayer == 1)
            players[currPlayer].GetComponent<Animator>().SetBool("SqrAnim", true);            
    }
}
