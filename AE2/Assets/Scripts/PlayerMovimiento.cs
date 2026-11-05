using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovimiento : MonoBehaviour
{
    public float speed = 5f;
    private Vector2 movement;
    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        Vector3 direction = new Vector3(movement.x, 0f, movement.y);
        rb.AddForce(direction * speed);
    }
    void OnMoveMando(InputValue value)
    {
        movement = value.Get<Vector2>();
    }
}
