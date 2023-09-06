using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    private TopDownCharaterController _controller;

    private Vector2 _movementDirection = Vector2.zero;
    private Rigidbody2D _rigibody;

    private void Awake()
    {
        _controller = GetComponent<TopDownCharaterController>();
        _rigibody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        _controller.OnMoveEvent += Move;
    }

    private void FixedUpdate()
    {
        ApplyMovment(_movementDirection);
    }

    private void Move(Vector2 direction)
    {
        _movementDirection = direction;
    }

 
    private void ApplyMovment (Vector2 direction)
    {
        direction = direction * 5;

        _rigibody.velocity = direction;
    }
}