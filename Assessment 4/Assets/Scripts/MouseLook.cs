using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MouseLook : MonoBehaviour
{

    public GameObject WinScreen;
    public GameObject UI_Menu;
    public float mouseSensitivity = 100f;
    public Transform PlayerBody;
    float Xrot = 0f;
    private Scene currentScene;
    private bool paused;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        paused = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            paused = true;
        }

        if (WinScreen.activeInHierarchy)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

        if (paused && !WinScreen.activeInHierarchy)
        {
            
            if (Input.GetMouseButtonDown(0))
            {
                    Cursor.lockState = CursorLockMode.Locked;
                    Cursor.visible = false;
                    paused = false;
            }
        }

        currentScene = SceneManager.GetActiveScene();
        if (currentScene.name == "Tut_Level" || currentScene.name == "Level_1" || currentScene.name == "Level_2" || currentScene.name == "Level_3" || currentScene.name == "Level_4")
        {
            PlayerRotate();
        }
    }

    void PlayerRotate()
    {
        float mousex = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        Xrot -= mouseY;
        Xrot = Mathf.Clamp(Xrot, -90, 90);
        transform.localRotation = Quaternion.Euler(Xrot, 0f, 0f);
        PlayerBody.Rotate(Vector3.up * mousex);
    }
}
