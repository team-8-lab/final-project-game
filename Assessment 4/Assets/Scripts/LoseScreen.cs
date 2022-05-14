using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseScreen : MonoBehaviour
{

    private GameObject[] lamps;
    private GameObject[] lampsOff;
    private GameObject[] doors;

    void Start()
    {
        lamps = GameObject.FindGameObjectsWithTag("Puzzle1Light");
        foreach(GameObject lamp in lamps)
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

    public void loadMenu()
    {
        SceneManager.LoadScene("Main_Menu");
    }
}

