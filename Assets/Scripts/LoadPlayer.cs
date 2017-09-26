using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadPlayer : MonoBehaviour {

    public GameObject[] playerModes;
    public int defaultPlayerMode;

    private GameObject mainPlayer;
    private GameObject sqrPlayer;
    private GameObject triPlayer;
    private GameObject[] players;
    private int currPlayer = 0;

    // Use this for initialization
    void Start () {
        mainPlayer = Instantiate(playerModes[defaultPlayerMode], transform.position, Quaternion.identity);
        mainPlayer.transform.parent = transform;

        sqrPlayer = Instantiate(playerModes[1], transform.position, Quaternion.identity);
        sqrPlayer.transform.parent = transform;
        sqrPlayer.SetActive(false);

        triPlayer = Instantiate(playerModes[2], transform.position, Quaternion.identity);
        triPlayer.transform.parent = transform;
        triPlayer.SetActive(false);
        players = new GameObject[3] { mainPlayer, sqrPlayer, triPlayer };
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


    public void changePlayer(int newPlayer)
    {
        players[currPlayer].SetActive(false);
        currPlayer = newPlayer;
        players[currPlayer].SetActive(true);
        Invoke("resetPlayer", 30);
    }

    void resetPlayer()
    {
        players[currPlayer].SetActive(false);
        currPlayer = 0;
        players[currPlayer].SetActive(true);
    }
}
