using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Launch", 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Launch()
    {
        float x = Random.Range(0,2) == 0 ? -1 : 1;
        float y = Random.Range(0,2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(speed * x, speed * y);
    }
}
