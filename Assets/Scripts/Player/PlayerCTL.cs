using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCTL : MonoBehaviour
{
    
    [Header("Playermovement")]
    public float maxSpeed = 5f;
    public float speed = 3f;
    private float h;
    private float v;
    private Rigidbody2D rb;
    private Vector2 movement;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Move();
    }
    
    void Move()
    {	
        float h;
        float v;
        
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");
        
        Vector2 moveVec = new Vector2(h, v);
        rb.velocity = moveVec * speed;
    }
}
