using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleCursor : MonoBehaviour
{
    void Update()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
}
