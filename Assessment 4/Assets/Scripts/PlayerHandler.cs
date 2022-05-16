﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


[RequireComponent(typeof(CharacterController))]
public class PlayerHandler : MonoBehaviour
{
    CharacterController controller;
    public float speed = 50f;
    public float sprint = 300f;
    public float jump = 2.0f; 
    public float gravity = -9.81f;
    Vector3 V;
    private Scene currentScene;
    private bool lockMovement;

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

        currentScene = SceneManager.GetActiveScene();
        if (currentScene.name == "Tut_Level" || currentScene.name == "Level_1" || currentScene.name == "Level_2" || currentScene.name == "Level_3" || currentScene.name == "Level_4")
        {
            PlayerMove();
        }

    }

    void PlayerMove()
    {
        float X = Input.GetAxis("Horizontal");
        float Z = Input.GetAxis("Vertical");
        Vector3 M = transform.right * X + transform.forward * Z;
        //controller.Move(M * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftShift) && (currentScene.name == "Level_2" || currentScene.name == "Level_3" || currentScene.name == "Level_4"))
        {
            controller.Move(M * sprint * Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.Space) && (currentScene.name == "Level_4"))
        {
            V.y = Mathf.Sqrt(jump * -2f * gravity);
        }

        else
        {
            controller.Move(M * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftControl) && (currentScene.name == "Level_3" || currentScene.name == "Level_4"))
        {
            controller.height = 10f;
        }
        else
        {
            controller.height = 50f;
        }

        V.y += gravity * Time.deltaTime;
        controller.Move(V * Time.deltaTime);
    }

}
