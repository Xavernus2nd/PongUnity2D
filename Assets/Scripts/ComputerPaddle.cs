
using UnityEngine;
using UnityEngine.UIElements;

public class ComputerPaddle : Paddle
{
    public Rigidbody2D ball;


    public void Awake()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }
    public void FixedUpdate()
    {
        if (ball.linearVelocityX > 1.0f)
        {
            if (ball.position.y > transform.position.y)
            {
                _rigidBody.AddForce((new Vector2(0, 1)) * speed);
            }
            else if (ball.position.y < transform.position.y)
            {
                _rigidBody.AddForce((new Vector2(0, -1)) * speed);
            }
        }
        else
        {
            if (transform.position.y > 0.0f)
            {
                _rigidBody.AddForce(Vector2.down * speed);
            }
            else if (transform.position.y < 0.0f)
            {
                _rigidBody.AddForce(Vector2.up * speed);
            }
        }
    }
}
