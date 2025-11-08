using UnityEngine;
using UnityEngine.Rendering;

public class Ball : MonoBehaviour
{
    public float speed = 350.0f;
    private Rigidbody2D _rigidBody;

    public void Awake()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        RestartMatch();
    }

    void Update()
    {
        
    }

    public void ResetBall()
    {
        _rigidBody.position = Vector3.zero;
        _rigidBody.linearVelocity = Vector3.zero;
    }

    private void AddInitialForce()
    {
        float x = Random.value < 0.5f ? -1.0f : 1.0f; // coinflips the initial direction of the ball
        float y = Random.Range(-1.0f, 1.0f);
        Vector2 direction = new Vector2(x, y); // initalizes the movement vector

        _rigidBody.AddForce(direction * speed); // applies the movement to rigidbody
    }

    public void AddImpulse(Vector2 force)
    {
        _rigidBody.AddForce(force, ForceMode2D.Impulse);
    }

    public void RestartMatch()
    {
        ResetBall();
        AddInitialForce();
    }

}
