using UnityEngine;
using UnityEngine.InputSystem;

public class BoxPickup : MonoBehaviour
{
    public Transform player;
    private bool _pickUpAllowed;
    private bool _holdingObject;

    void Update()
    {
        if (_pickUpAllowed == true && Keyboard.current.eKey.wasPressedThisFrame)
        {
            transform.SetParent(player);
            transform.position = new Vector2(player.position.x, player.position.y + 1);
            _holdingObject = true;
            _pickUpAllowed = false;
        }
        else if (_holdingObject == true && Keyboard.current.eKey.wasPressedThisFrame)
        {
            transform.SetParent(null);
            transform.position = new Vector2(player.position.x + (1 * player.localScale.x), player.position.y);
            _holdingObject = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _pickUpAllowed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            _pickUpAllowed = false;
        }
    }
}
