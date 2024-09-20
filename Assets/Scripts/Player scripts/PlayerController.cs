using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;

    private InputActions _input;
    private Rigidbody2D _rigidbody2D;
    
    void Start()
    {
        _input = GetComponent<InputActions>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        if (_input.Horizontal != 0)
        {
            transform.localScale = new Vector2(Mathf.Sign(_input.Horizontal), 1);
        }
    }

    void FixedUpdate()
    {
        _rigidbody2D.linearVelocityX = _input.Horizontal * moveSpeed;
        _rigidbody2D.linearVelocityY = _input.Vertical * moveSpeed;
    }
}
