using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FlipperController : MonoBehaviour
{
    [field: SerializeField]
    public float HeldRotation { get; private set; }
    [field: SerializeField]
    public float DefaultRotation { get; private set; }
    [field: SerializeField]
    public bool IsHeld { get; set; } = false;
    [field: SerializeField]
    public float Speed = 4;
    private Rigidbody2D _rigidbody;

    // Start is called before the first frame update
    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        transform.rotation = Quaternion.Euler(0, 0, HeldRotation);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float targetRotation = DefaultRotation;
        // Mathf.Lerp(_rigidbody.rotation, targetRotation, );
        if (IsHeld)
        {
            targetRotation = HeldRotation;
        }
        float change = targetRotation - _rigidbody.rotation;
        float max = 360 * Speed * Time.deltaTime;
        change = Math.Clamp(change, -max, max);
        float rotation = _rigidbody.rotation + change;
        _rigidbody.MoveRotation(rotation);
    }

    
}
