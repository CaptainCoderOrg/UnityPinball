using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public FlipperController RightFlipper;
    public FlipperController LeftFlipper;

    void OnRightFlipper(InputValue value)
    {
        RightFlipper.IsHeld = value.isPressed;
    }

    void OnLeftFlipper(InputValue value)
    {
        LeftFlipper.IsHeld = value.isPressed;
    }
}
