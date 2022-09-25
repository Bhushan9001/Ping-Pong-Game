
using UnityEngine;

public class BounceSurface : MonoBehaviour
{
    public float BounceStrength = 9.0f ;  // strength to bounce back the ball on each collision.

private void OnCollisionEnter2D(Collision2D collision) { // this function get called on each collision of ball.
     Ball ball = collision.gameObject.GetComponent<Ball>();// detecting the collided object is ball
   

     if(ball != null){ // if collided object is ball
        Vector2 normal = collision.GetContact(0).normal; // getting the normal of angle of first contact.
        ball.AddForce(-normal*this.BounceStrength); // adds force and sped on each collision
     }
}
}
