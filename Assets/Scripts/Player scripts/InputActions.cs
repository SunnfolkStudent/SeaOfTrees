using System;
using UnityEngine;

public class InputActions : MonoBehaviour
{
    public float Horizontal;
    public float Vertical;
    public bool Interact;
    private InputSystem_Actions _inputSystem;

    private void Update()
    {
        Horizontal = _inputSystem.Player.Move.ReadValue<Vector2>().x;
        Vertical = _inputSystem.Player.Move.ReadValue<Vector2>().y;
        Interact = _inputSystem.Player.Interact.WasPressedThisFrame();
    }

    void Awake()
    {
        _inputSystem = new InputSystem_Actions();
    }

    private void OnEnable() { _inputSystem.Enable(); }
    private void OnDisable() { _inputSystem.Disable(); }
}