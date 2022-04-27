using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(GameObject.Find("Terrain"));
        Destroy(GameObject.Find("Player"));
    }

    // Update is called once per frame
    public void loadTutorial()
    {
        SceneManager.LoadScene("Tut_Level");
    }
}

