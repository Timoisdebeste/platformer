using UnityEngine;

public class playermovement : MonoBehaviour
{
    private Rigidbody2d body;


    private void Start() => body = getcomponent<rigidbody2D>();


    private void Update()
    {
        body.velocity = new vector2(input.getaxis, 0, 0);
    }
}
