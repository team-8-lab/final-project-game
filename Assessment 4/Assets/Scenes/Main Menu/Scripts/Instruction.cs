using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Instruction : MonoBehaviour
{
    public void loadTutorial()
    {
        SceneManager.LoadScene("Tut_Level");
    }
}
