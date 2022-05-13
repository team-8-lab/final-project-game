using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(BoxCollider))]
public class LoadPuzzle : MonoBehaviour
{

    public string currentScene;

    public LightController LC;
    private Color startColour;

    private void Start()
    {
        startColour = this.gameObject.GetComponent<Renderer>().material.color;
    }

    void OnTriggerStay(Collider other)
    {
        OnMouseDown();
    }

    void OnMouseDown()
    {
        currentScene = SceneManager.GetActiveScene().name;
        if (currentScene == "Tut_Level")
        {
            SceneManager.LoadScene("Tut_Puzzle1", LoadSceneMode.Additive);
        }
        

        switch (currentScene)
        {
            case "Level_1":
                SceneManager.LoadScene("Level1_Puzzle", LoadSceneMode.Additive);
                break;
            case "Level_2":
                SceneManager.LoadScene("Level2_Puzzle", LoadSceneMode.Additive);
                break;
            case "Level_3":
                SceneManager.LoadScene("Level3_Puzzle", LoadSceneMode.Additive);
                break;
            case "Level_4":
                SceneManager.LoadScene("Level4_Puzzle", LoadSceneMode.Additive);
                break;
        }
        
        LC.PuzzleComplete(true);
    }
    void OnMouseOver()
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
    }
    void OnMouseExit()
    {
        this.gameObject.GetComponent<Renderer>().material.color = startColour;
    }

}
