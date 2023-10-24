using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoring : MonoBehaviour
{
    public bool isPlayer1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (isPlayer1)
        {
            FindObjectOfType<GameManager>().Player1Scored();
        }
        else
        {
            FindObjectOfType<GameManager>().Player2Scored();
        }
    }
}
