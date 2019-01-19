﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;

    public void handleKeyPress(string input)
    {
        switch(input[0])
        {
            case '0':
                player1.GetComponent<PlayerTopMovement>().PlayerMove(input[1]);
                break;
            case '1':
                player2.GetComponent<PlayerRightMovement>().PlayerMove(input[1]);
                break;
            case '2':
                player3.GetComponent<PlayerBottomMovement>().PlayerMove(input[1]);
                break;
            case '3':
                player4.GetComponent<PlayerLeftMovement>().PlayerMove(input[1]);
                break;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}