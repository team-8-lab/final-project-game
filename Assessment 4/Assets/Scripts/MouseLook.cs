using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    public GameObject WinScreen;
    public GameObject LoseScreen;
    public float mouseSensitivity = 100f;
    public Transform PlayerBody;
    float Xrot = 0f;

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
            if (Input.GetMouseButtonDown(0) && !WinScreen.activeInHierarchy && !LoseScreen.activeInHierarchy)
            {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
        }

        float mousex = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        Xrot -= mouseY;
        Xrot = Mathf.Clamp(Xrot, -90, 90);
        transform.localRotation = Quaternion.Euler(Xrot,0f,0f);
        PlayerBody.Rotate(Vector3.up * mousex);
    }
}
