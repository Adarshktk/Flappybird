using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Fly : MonoBehaviour
{
    [SerializeField] private float velocity = 1.5f;
    [SerializeField] private float rotationSpeed = 10f;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, 0, rb.velocity.y * rotationSpeed);
    }
    private void Update()
    {
        if (InputManager.isLeftMousePressed)
        {
            rb.velocity = Vector2.up * velocity;
        }
        
    }

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Gamehandler.Instance.GameOver();
    }
}
