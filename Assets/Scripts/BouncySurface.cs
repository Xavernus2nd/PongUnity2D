
using UnityEngine;

public class BouncySurface : MonoBehaviour
{
    public float bounceStrength;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>(); // gets the collision and attempts to get a ball component from the collision

        if(ball != null)
        {
            Vector2 normal = collision.GetContact(0).normal;
            ball.AddImpulse(-normal * bounceStrength);
        }
    }
}