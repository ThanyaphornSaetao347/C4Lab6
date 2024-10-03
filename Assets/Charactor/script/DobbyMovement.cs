using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DobbyMovement : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim;
    // public float speed = 10.0f;
    // public float rotationSpeed = 100.0f;
    // public float force = 700.0f;
    // public float jumpForce = 700.0f;
    // public float gravity = 20.0f;
    // public bool isGrounded = false;
    // public bool isDef = false;
    // public bool isDancing = false;
    // public bool isWalking = false;
    // Vector3 moveDirection = Vector3.zero;
    CharacterController controller;
    void Start()
    {
        anim = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
        //Animation Controller parameters for the character
        anim.SetBool("isOld", false);
        anim.SetBool("isWalking", false);
        anim.SetBool("isDancing", false);
        //Time to start the animation
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        // float x = -(Input.GetAxis("Vertical"));
        // float z = Input.GetAxis("Horizontal");
        // Vector3 inputDirection = new Vector3(x, 0, z);

        // if (x != 0 || z != 0)
        // {
        //     // anim.SetBool("isDef", false);
               // anim.SetBool("isWalking", true);
        // }
        // else
        // {
        //     anim.SetBool("isDef", true);
        //     anim.SetBool("isWalking", false);
        // }

        if (Input.GetKey(KeyCode.W))
        {
            anim.SetBool("isOld", true);
            anim.SetBool("isWalking", true);
            anim.SetBool("isDancing", false);
            Debug.Log("W key is pressed");
        }
        else if (Input.GetKey(KeyCode.S))
        {
            anim.SetBool("isOld", true);
            anim.SetBool("isWalking", false);
            anim.SetBool("isDancing", false);
            Debug.Log("S key is pressed");
        }
        else if (Input.GetKey(KeyCode.D))
        {
            anim.SetBool("isOld", true);
            anim.SetBool("isDancing", true);
            anim.SetBool("isWalking", false);
            Debug.Log("D key is pressed");
        }
        else if (Input.GetKey(KeyCode.E))
        {
            anim.SetBool("isOld", true);
            anim.SetBool("isDancing", false);
            anim.SetBool("isWalking", false);
            Debug.Log("E key is pressed");
        }
        else if (Input.GetKey(KeyCode.F))
        {
            anim.SetBool("isWalking", true);
            anim.SetBool("isDancing", true);
            anim.SetBool("isOld", false);
            Debug.Log("F key is pressed");
        }
        else if (Input.GetKey(KeyCode.G))
        {
            anim.SetBool("isWalking", true);
            anim.SetBool("isDancing", false);
            anim.SetBool("isOld", false);
            Debug.Log("G key is pressed");
        }
        
        // if (Input.GetKey(KeyCode.W))
        // {
        //     anim.SetBool("isWalking", true);
        //     anim.SetBool("isArm Stretching", true);
        //     anim.SetBool("isSilly Dancing", false);
        //     Debug.Log("W key is pressed");
        // }
        // else if (Input.GetKey(KeyCode.S))
        // {
        //     anim.SetBool("isWalking", true);
        //     anim.SetBool("isSilly Dancing", true);
        //     anim.SetBool("isArm Stretching", false);
        //     Debug.Log("S key is pressed");
        // }
        // else if (Input.GetKey(KeyCode.D))
        // {
        //     anim.SetBool("isSilly Dancing", true);
        //     anim.SetBool("isArm Stretching", true);
        //     anim.SetBool("isWalking", false);
        //     Debug.Log("D key is not pressed");
        // }

        // if (controller.isGrounded)
        // {
        //     moveDirection = transform.TransformDirection(inputDirection);
        //     moveDirection *= speed;
        //     if (Input.GetButton("Jump"))
        //     {
        //         moveDirection.y = jumpForce;
        //     }
        // }
    }
}