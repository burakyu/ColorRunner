using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DELETEPlayerJoystickMovement : Player
{
    [HideInInspector]
    //public FloatingJoystick floatingJoystick;

    public float speed;
    //public float turnSpeed;
    
    private Animator playerAnim;
    // Start is called before the first frame update
    void Start()
    {
       // floatingJoystick = FindObjectOfType<FloatingJoystick>();
        //playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //PlayerMovement();

        //AnimationSetup();
    }

    //void PlayerMovement()
    //{
    //    transform.Translate(Vector3.forward * Time.deltaTime * speed);



    //   // transform.position = new Vector3(transform.position.x + floatingJoystick.Horizontal * speed * Time.deltaTime, transform.position.y, transform.position.z);


    //    //Vector3 movementDirection = new Vector3(floatingJoystick.Horizontal, 0, floatingJoystick.Vertical);
    //    //movementDirection.Normalize();

    //    //if (movementDirection != Vector3.zero)
    //    //{
    //    //    Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);

    //    //    transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, turnSpeed * Time.deltaTime);
    //    //}
    //}

    //void AnimationSetup()
    //{
    //    if (variableJoystick.Horizontal!=0 || variableJoystick.Vertical!=0)
    //    {
    //        playerAnim.SetFloat("Speed_f", 1);
    //    }
    //    else
    //    {
    //        playerAnim.SetFloat("Speed_f", 0);
    //    }

    //    if (StackManager.Instance.collectedCount>0)
    //    {
    //        playerAnim.SetBool("Carry",true);
    //    }
    //    else
    //    {
    //        playerAnim.SetBool("Carry", false);
    //    }
    //}
}
