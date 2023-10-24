using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    private Vector2 startPosition;

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
}
