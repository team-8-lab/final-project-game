﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD
using UnityEngine.SceneManagement;
=======
>>>>>>> Lights

[RequireComponent(typeof(CharacterController))]
public class PlayerHandler : MonoBehaviour
{
    CharacterController controller;
    public float speed = 50f;
    public float gravity = -9.81f;
    Vector3 V;
<<<<<<< HEAD
=======
    
>>>>>>> Lights

    private void Awake()
    {
        controller = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (controller.isGrounded && V.y < 0)
        {
            V.y = -2f;
        }

        float X = Input.GetAxis("Horizontal");
        float Z = Input.GetAxis("Vertical");
        Vector3 M = transform.right * X + transform.forward * Z;
        controller.Move(M * speed * Time.deltaTime);

        V.y += gravity * Time.deltaTime;
        controller.Move(V * Time.deltaTime);
    }
<<<<<<< HEAD

=======
>>>>>>> Lights
}
