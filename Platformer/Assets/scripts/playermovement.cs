using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody2D rb;

    public float sp;
    public float jump;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * sp, rb.velocity.y);

        if (Input.GetKey(KeyCode.Space))
            rb.velocity = new Vector2(rb.velocity.x, jump);
    }

}
