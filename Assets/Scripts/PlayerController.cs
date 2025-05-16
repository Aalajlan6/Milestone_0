using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private float movementX;
    private float movementY;

    public float speed = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Debug.Log("PlayerController initialized. Rigidbody component assigned.");
    }

    public void OnMove(InputValue movementValue)
    {
        Debug.Log("OnMove method triggered.");
        Vector2 movementVector = movementValue.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y;
        Debug.Log($"Movement Input: X = {movementX}, Y = {movementY}");
    }

    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement * speed);
        Debug.Log($"FixedUpdate called. Applying force: {movement}");
    }
}
