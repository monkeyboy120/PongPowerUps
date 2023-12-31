using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour
{
    public bool isPlayer1;

    public float speed;

    public Rigidbody2D rb;

    private float movement;

    private Vector3 initialScale;
    private float initialSpeed;

    private void Start()
    {
        initialScale = transform.localScale;
        initialSpeed = speed;
    }

    void Update()
    {
        if (isPlayer1)
            movement = Input.GetAxisRaw("Vertical");
        else
            movement = Input.GetAxisRaw("Vertical2");

        rb.velocity = new Vector2(rb.velocity.x, movement * speed);
    }

    public void ChangeSize(float scaleFactor)
    {
        Vector3 newScale = initialScale;
        newScale.y *= scaleFactor;
        transform.localScale = newScale;
        StartCoroutine(ResetAfterDelay());
    }

    public void ChangeSpeed(float speedMultiplier)
    {
        speed = initialSpeed * speedMultiplier;
        StartCoroutine(ResetAfterDelay());
    }

    public void Reset()
    {
        transform.localScale = initialScale;
        speed = initialSpeed;
    }

    IEnumerator ResetAfterDelay()
    {
        yield return new WaitForSeconds(7f);
        Reset();
    }
}
