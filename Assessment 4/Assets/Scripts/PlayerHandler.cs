using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


[RequireComponent(typeof(CharacterController))]
public class PlayerHandler : MonoBehaviour
{
    CharacterController controller;
    public float speed = 50f;
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
        if (currentScene.name == "Tut_Level" || currentScene.name == "Level_1" || currentScene.name == "Level_3")
        {
            PlayerMove();
        }
        
    }

    void PlayerMove()
    {
        float X = Input.GetAxis("Horizontal");
        float Z = Input.GetAxis("Vertical");
        Vector3 M = transform.right * X + transform.forward * Z;
        controller.Move(M * speed * Time.deltaTime);

        V.y += gravity * Time.deltaTime;
        controller.Move(V * Time.deltaTime);
    }

}
