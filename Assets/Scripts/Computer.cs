using UnityEngine;

public class Computer : Paddle
{
    public Rigidbody2D ball;  //rigid body reference of gameobject

    private void FixedUpdate() // gets called after fixed interval of frames
    {

        if (this.ball.velocity.x > 0.0f)//if ball is moving toward padel.
        {

            if (this.ball.position.y > this.transform.position.y)//if position of ball is higher than padel.
            {
                _rigidbody.AddForce(Vector2.up * this.speed);//move padel to upward direction.
            }
            else if (this.ball.position.y < this.transform.position.y)//if position of ball is lower than padel.
            {
                _rigidbody.AddForce(Vector2.down * this.speed);//move padel to downward direction
            }
        }
        else // when ball is not moving towards computer.
        {

            if (this.transform.position.y > 0.0f) // if padels position is higher 
            {
                _rigidbody.AddForce(Vector2.down * this.speed);// move padel to downward 
            }
            else if (this.transform.position.y < 0.0f)//if padels position is lower
            {
                _rigidbody.AddForce(Vector2.up * this.speed); // move padel to downward.
            }
        }
    }
}
