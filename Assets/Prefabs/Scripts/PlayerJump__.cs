using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerJump__ : MonoBehaviour
{
    public InputActionReference jump;
    public float jumpHeight = 3f;
    public CharacterController cc;

    [SerializeField] private LayerMask groundLayers;

    private float gravity = Physics.gravity.y;
    private Vector3 move;

    void Update()
    {
        bool isGrounded = IsGround();
        if (jump.action.triggered && isGrounded)
        {
            Jump();
        }
        move.y += gravity * Time.deltaTime;
        cc.Move(move * Time.deltaTime);
    }

    private void Jump()
    {
        move.y = Mathf.Sqrt(jumpHeight * -3.0f * gravity);
    }

    private bool IsGround()
    {
        return Physics.CheckSphere(transform.position, 0.2f, groundLayers);
    }
}
