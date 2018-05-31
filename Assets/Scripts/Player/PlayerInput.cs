using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float inputH, inputV;
    public float speed;
    public bool isSprinting, isCrouching;
    public Animator ethan;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        inputH = Input.GetAxis("Horizontal");
        inputV = Input.GetAxis("Vertical");
        speed *= inputV;
        EthanHorizontalMovement();
        EthanVerticalMovement();        
        
        if (Input.GetKey(KeyCode.LeftShift))
        {
            isSprinting = true;
        }
        else
        {
            isSprinting = false;
        }
        ethan.SetBool("isSprinting", isSprinting);
        if (Input.GetKey(KeyCode.C))
        {
            isCrouching = true;
        }
        else
        {
            isCrouching = false;
        }
        ethan.SetBool("isCrouching", isCrouching);
    }

    void EthanVerticalMovement()
    {
        ethan.SetFloat("speed", inputV);
    }

    void EthanHorizontalMovement()
    {
        ethan.SetFloat("inputH", inputH);
        // If Ethan is moving forward
        if (speed > 0)
        {
            // If not turning
            if (inputH == 0)
            {

            }
            // If turning left
            if (inputH < 0)
            {

            }
            // If turning right
            if (inputH > 0)
            {

            }
        }
    }
}
