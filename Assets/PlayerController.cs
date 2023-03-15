using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float boostSpeed=30f;
    [SerializeField] float baseSpeed=20f;
    [SerializeField] float torqueAmount=1f;
    SurfaceEffector2D surfaceEffector2D;

   Rigidbody2D rb2d;
    void Start()
    {
      rb2d=  GetComponent<Rigidbody2D>();  
      surfaceEffector2D =FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        RotatePlayer();
        RespondToBoost();
    }

     void RespondToBoost()
    {
        if(Input.GetKey(KeyCode.W)){
            surfaceEffector2D.speed=boostSpeed;
        }
        else {
            surfaceEffector2D.speed=baseSpeed;
        }
    }

     void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb2d.AddTorque(-torqueAmount);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb2d.AddTorque(torqueAmount);
        }
    }
}
