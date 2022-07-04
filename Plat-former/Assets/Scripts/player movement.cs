using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    } 


    private void Update()
    {
        body.velocity = new vector2(input.getaxis, 0, 0);
    }
}
