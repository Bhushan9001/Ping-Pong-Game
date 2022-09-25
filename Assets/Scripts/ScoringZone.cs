using UnityEngine.EventSystems; // to acces the event system of unity .
using UnityEngine;

public class ScoringZone : MonoBehaviour
{
    public EventTrigger.TriggerEvent ScoreTrigger; // setting a trigger to change scores on collisions
    private void OnCollisionEnter2D(Collision2D collision) // detects the collision and called on each collision.
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();// collided object is ball.


        if (ball != null)// if collided object is ball
        {
            BaseEventData eventData = new BaseEventData(EventSystem.current); // variable to store the event data.
             this.ScoreTrigger.Invoke(eventData);
        }
    }
}
