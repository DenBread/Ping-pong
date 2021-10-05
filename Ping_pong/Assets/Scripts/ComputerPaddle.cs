using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerPaddle : Paddle
{
    [SerializeField] private Rigidbody2D _ball;

    private void FixedUpdate()
    {
        if (_ball.velocity.x > 0.0f)
        {
            if (_ball.position.y > transform.position.y)
            {
                _rigidbody.AddForce(Vector2.up * this.speed);
            }
            else if(_ball.position.y < transform.position.y)
            {
                _rigidbody.AddForce(Vector2.down * speed);
            }
        }
        else
        {
            if (transform.position.y > 0.0f)
            {
                _rigidbody.AddForce(Vector2.down * speed);
            }
            else if(transform.position.y < 0.0f)
            {
                _rigidbody.AddForce(Vector2.up * speed);
            }
        }
    }
}
