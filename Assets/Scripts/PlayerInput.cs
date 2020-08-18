using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float ForwardBackward { get; private set; }

    public float LeftRight { get; private set; }

    public bool Jump { get; private set; }

    public bool Action { get; private set; }

    public void Update()
    {
        ForwardBackward = Input.GetAxis("Horizontal");

        LeftRight = Input.GetAxis("Vertical");

        Jump = Input.GetButtonDown("Jump");

        Action = Input.GetButtonDown("Action");
    }
}
