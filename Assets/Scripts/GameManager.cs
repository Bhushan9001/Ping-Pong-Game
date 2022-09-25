using UnityEngine.UI;     //library for maintaining and changing UI components 
using UnityEngine;

public class GameManager : MonoBehaviour
{
 
//all vaarialble and instances of another game objects 

//variables for updating text
    public Text playerScoreText;
    public Text ComputerScoreText;

//padel objects to manipulate player and computer padel
    public Paddle playerPadel;
    public Paddle ComputerPadel;

//instance of ball object 
    public Ball ball;

//variables for tracking scores 
    private int playerScore;
    private int computerScore;

    public void PlayerScores()  //updates player score
    {
        playerScore++;
        this.playerScoreText.text = playerScore.ToString(); //player score text update
        ResetRound();                  
    }
    public void ComputerScores() //updates computer score
    {
        computerScore++;
        this.ComputerScoreText.text = computerScore.ToString(); //computer score text update
        ResetRound();
    }
    private void ResetRound()          //reseting padels , ball 
    {
        this.ball.ResetBall();         //reset ball position to center
        this.ball.AddStartingForce();  // reinitailize spped of ball
        this.playerPadel.ResetPosition();  // player padel  to center
        this.ComputerPadel.ResetPosition();  // computer padel to center
 
    }
}


