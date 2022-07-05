using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody2D rb;

    public float sp;
    public float jstr;
    public bool grnd;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * sp, rb.velocity.y);

        if (Input.GetKey(KeyCode.Space) && grnd)
            jump();
    }

    private void jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jstr);
        grnd = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
            grnd = true;
    }
}
