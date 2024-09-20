using UnityEngine;

public class BoxPickup : MonoBehaviour
{
    private bool _pickUpAllowed;
    private Rigidbody2D _rigidBody2D;
    private InputActions _input;
    void Start()
    {
        _rigidBody2D = GetComponent<Rigidbody2D>();
        _input = GetComponent<InputActions>();
    }

    void Update()
    {
        if (_pickUpAllowed && _input)
        {
            PickUp();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _pickUpAllowed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _pickUpAllowed = false;
        }
    }

    private void PickUp()
    {
        
    }
}
