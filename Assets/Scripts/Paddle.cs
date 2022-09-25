
using UnityEngine;

public class Paddle : MonoBehaviour // common script for both padels.
{
    public float speed = 10.0f; // speed of padels. public variable we can change manually in gameEngine.
     protected Rigidbody2D _rigidbody; // rigid body refernce of each respective padel.

 private void Awake() { // this function is only called one time .
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    public void ResetPosition(){
        _rigidbody.position = new Vector2(_rigidbody.position.x , 0.0f);//setting the padel position to center.
        _rigidbody.velocity = Vector2.zero;// setting velocity to 0.
    }
}
