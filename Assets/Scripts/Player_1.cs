using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_1 : Paddle
{
    private Vector2 directions; // variable to set direction according to SecondPlayer input.
    private void Update()//Update() is called at every frame of game.
    {

        if ( Input.GetKey(KeyCode.W)) // move uppwards if input keys are W or upkey.
        {
            directions = Vector2.up;//set direction to up.

        }
        else if ( Input.GetKey(KeyCode.S))// move downwards if SecondPlayer input keys are S or downkey.
        {
            directions = Vector2.down;//set direction to down.
        }
        else// if SecondPlayer input is not correct 
        {
            directions = Vector2.zero;// set direction to 0.
        }

    }

    
    void FixedUpdate()
    {
        if (directions.sqrMagnitude != 0) // if our padel is moving , equals to 0 means padel is not moving.
        {
            _rigidbody.AddForce(directions*this.speed);//add speed to directions.
        }
    }
}
