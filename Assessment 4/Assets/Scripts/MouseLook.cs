using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MouseLook : MonoBehaviour
{

    public GameObject WinScreen;
    public float mouseSensitivity = 100f;
    public Transform PlayerBody;
    float Xrot = 0f;
    private Scene currentScene;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

        if (Cursor.lockState == CursorLockMode.None)
        {
            if (Input.GetMouseButtonDown(0) && !WinScreen.activeInHierarchy)
            {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
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
