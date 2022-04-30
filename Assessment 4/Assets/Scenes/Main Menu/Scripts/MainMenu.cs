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

    }

    // Update is called once per frame
    public void loadTutorial()
    {
        SceneManager.LoadScene("Tut_Level");
    }
}

