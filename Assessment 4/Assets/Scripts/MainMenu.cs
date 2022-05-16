using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private GameObject[] lamps;
    private GameObject[] lampsOff;
    private GameObject[] doors;

    // Start is called before the first frame update
    void Start()
    {

        lamps = GameObject.FindGameObjectsWithTag("Puzzle1Light");
        foreach (GameObject lamp in lamps)
        {
            Destroy(lamp);
        }

        lampsOff = GameObject.FindGameObjectsWithTag("Puzzle1LightOFF");
        foreach (GameObject lampOFF in lampsOff)
        {
            Destroy(lampOFF);
        }
        doors = GameObject.FindGameObjectsWithTag("Door");
        foreach (GameObject door in doors)
        {
            Destroy(door);
        }
        Destroy(GameObject.Find("Maze"));
        Destroy(GameObject.Find("Player"));
        Destroy(GameObject.Find("Lamp_ON_Light"));
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

    public void loadLevel3()
    {
        SceneManager.LoadScene("Level_3");
    }

    public void loadLevel2()
    {
        SceneManager.LoadScene("Level_2");
    }

    public void loadLevel2Intro()
    {
        SceneManager.LoadScene("Level2_Introduction_New_Mechanism");
    }

    public void loadLevel3Intro()
    {
        SceneManager.LoadScene("Level3_Introduction_New_Mechanism");
    }
}

