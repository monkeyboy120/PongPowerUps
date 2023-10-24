using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Header("Ball")] public GameObject ball;

    [Header("Player1")]
    public GameObject player1;
    public GameObject leftWall;

    [Header("Player2")]
    public GameObject player2;
    public GameObject rightWall;

    [Header("Score")]
    public TextMeshProUGUI player1scoretext;
    public TextMeshProUGUI player2scoretext;

    private int player1score = 0;
    private int player2score = 0;

    public void Player1Scored()
    {
        player1score++;
        player1scoretext.text = player1score.ToString();
        Reset();
    }

    public void Player2Scored()
    {
        player2score++;
        player2scoretext.text = player2score.ToString();
        Reset();
    }

    public void Reset()
    {
        FindObjectOfType<BallScript>().Reset();
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        if (player1score == 11)
            SceneManager.LoadScene("Victory1");

        if (player2score == 11)
            SceneManager.LoadScene("Victory2");
    }
}
