
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D _rigidbody;   //store rigidboady of gameobject to whoom script is attached 
    public float speed = 250.0f;   //speed of ball
    private void Awake() {
        _rigidbody = GetComponent<Rigidbody2D>();   //store rigidboady of gameobject to whoom script is attached 
    }
    private void Start() {    // start function is called at start of game or at first frame
        ResetBall();
        AddStartingForce();     
    }

    public void ResetBall(){
        _rigidbody.velocity = Vector3.zero;  //setting ball velocity to 0
        _rigidbody.position = Vector3.zero;  //setting ball position to center
        }
       
    public void AddStartingForce(){
        
        float x = Random.value < 0.5f ? -1.0f : 1.0f; //random value gives 0 or 1 . -1.0f = towards left , 1.0f towards right. sets the direction of ball at start
        float y = Random.value < 0.5f ? Random.Range(-1.0f , -0.5f): Random.Range(0.5f , 1.0f);// to set the angle of ball at start.


         Vector2 direction = new Vector2(x,y);  //sets direction.

        _rigidbody.AddForce(direction*speed);   //gives speed to ball
          

    }

    public void AddForce(Vector2 force){ //for increasing the speed of ball

        _rigidbody.AddForce(force);
    }

}
