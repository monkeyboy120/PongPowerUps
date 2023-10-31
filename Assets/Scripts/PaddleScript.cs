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
        transform.localScale = initialScale * scaleFactor;
    }

    public void ChangeSpeed(float speedMultiplier)
    {
        speed = initialSpeed * speedMultiplier;
    }

    public void Reset()
    {
        transform.localScale = initialScale;
        speed = initialSpeed;
    }
}
