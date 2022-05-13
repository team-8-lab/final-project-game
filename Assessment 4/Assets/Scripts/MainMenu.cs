using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(GameObject.Find("Maze"));
        Destroy(GameObject.Find("Player"));
        Destroy(GameObject.Find("Lamps"));
        Destroy(GameObject.Find("Door"));
        Destroy(GameObject.Find("Puzzle_Lamp_ON (1)"));
        Destroy(GameObject.Find("Puzzle_Lamp_ON (2)"));
        Destroy(GameObject.Find("Puzzle_Lamp_ON (3)"));
        Destroy(GameObject.Find("Puzzle_Lamp_ON (4)"));
        Destroy(GameObject.Find("Puzzle_Lamp_ON (5)"));
        Destroy(GameObject.Find("Lamp_OFF (1)"));
        Destroy(GameObject.Find("Lamp_OFF (2)"));
        Destroy(GameObject.Find("Lamp_OFF (3)"));
        Destroy(GameObject.Find("Lamp_OFF (4)"));
        Destroy(GameObject.Find("Lamp_OFF (5)"));
        Destroy(GameObject.Find("DarknessMesh"));
        Destroy(GameObject.Find("DarknessMesh 2"));

    }

    // Update is called once per frame
    public void loadTutorial()
    {
        //SceneManager.LoadScene("Tut_Level");
        SceneManager.LoadScene("Instruction_Scene");
    }

    public void loadLevel1()
    {
        SceneManager.LoadScene("Level_1");
    }
}

