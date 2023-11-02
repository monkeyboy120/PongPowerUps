using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BallScript : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    private Vector2 startPosition;
    public AudioSource audioSource;

    void Start()
    {
        startPosition = transform.position;
        Invoke("Launch", 2f);
    }

    private void Launch()
    {
        float x = Random.Range(0,2) == 0 ? -1 : 1;
        float y = Random.Range(0,2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(speed * x, speed * y);
    }

    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
        Invoke("Launch", 2f);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        audioSource.Play();
    }
}
