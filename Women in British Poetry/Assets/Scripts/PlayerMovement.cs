using System;
using System.Collections;
using System.Collections.Generic;
//using UnityEditor.U2D.Path.GUIFramework;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public Animator animator;
    //public Animator orbAnimator;

    public float runSpeed = 40;
    public float smooth = 0.5f;

    float horizontalMove = 0f;
    bool crouch = false;
    bool jump = false;
    bool climb = false;


    void Update()
    {
        if (!climb)
        {
            horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        }
        else
        {
            horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed * .1f;
        }

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        //Debug.Log(Mathf.Abs(horizontalMove));


        // Jump Control
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            //animator.SetBool("IsJumping", true);
        }

        // Crouch Control
        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;

        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
    }

    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
    }

    void FixedUpdate()
    {
        // Updating Physics Controls
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("ladder"))
        {
            Debug.Log("True nao");
            animator.SetBool("isClimbing", true);
            climb = true;
        }

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("ladder") && climb)
        {
            Debug.Log("False nao");
            animator.SetBool("isClimbing", false);
            climb = false;
        }
    }
}
