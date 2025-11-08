using UnityEngine;

public class Player2Paddle : Paddle
{
    private Vector2 _direction;

    public void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            _direction = Vector2.up;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            _direction = Vector2.down;
        }
        else
        {
            _direction = Vector2.zero;
        }
    }

    public void FixedUpdate()
    {
        if(_direction.sqrMagnitude != 0)
        {
            _rigidBody.AddForce(_direction * this.speed);
        }
    }

}
