using UnityEngine;

public class Paddle : MonoBehaviour
{
    protected Rigidbody2D _rigidBody;
    public float speed = 20.0f;

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }
}
