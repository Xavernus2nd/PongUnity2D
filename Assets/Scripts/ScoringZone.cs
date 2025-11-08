
using UnityEngine;
using UnityEngine.EventSystems;


public class ScoringZone : MonoBehaviour
{
    public EventTrigger.TriggerEvent ScoreTrigger;
    public void OnCollisionEnter2D(Collision2D collision)
    {

        Ball ball = collision.gameObject.GetComponent<Ball>(); // gets the collision and attempts to get a ball component from the collision
        if(ball != null)
        {
            BaseEventData eventData = new BaseEventData(EventSystem.current);
            ScoreTrigger.Invoke(eventData);
        }
    }
}