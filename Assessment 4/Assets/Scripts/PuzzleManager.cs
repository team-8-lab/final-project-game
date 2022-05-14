using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuzzleManager : MonoBehaviour
{
    public GameObject PuzzleHolder;
    public GameObject[] Pieces;
    public Scene previousScene;

    [SerializeField]
    int totalPieces = 0;

    [SerializeField]
    int correctPieces = 0;

    // Start is called before the first frame update
    void Start()
    {
        previousScene = SceneManager.GetActiveScene();
        totalPieces = PuzzleHolder.transform.childCount;

        Pieces = new GameObject[totalPieces];

        for(int i = 0; i < Pieces.Length; i++)
        {
            Pieces[i] = PuzzleHolder.transform.GetChild(i).gameObject;
        }
    }

    public void correctMove()
    {
        correctPieces += 1;
        if (correctPieces == totalPieces)
        {
            if(previousScene.name == "Tut_Level")
            {
                SceneManager.LoadScene("Tut_Level");
                SceneManager.UnloadSceneAsync(previousScene.buildIndex);
            }
            else if (previousScene.name == "Level_1")
            {
                SceneManager.LoadScene("Level_1");
                SceneManager.UnloadSceneAsync(previousScene.buildIndex);
            }
            else if (previousScene.name == "Level_2")
            {
                SceneManager.LoadScene("Level_2");
                SceneManager.UnloadSceneAsync(previousScene.buildIndex);
            }
            else if (previousScene.name == "Level_3")
            {
                SceneManager.LoadScene("Level_3");
                SceneManager.UnloadSceneAsync(previousScene.buildIndex);
            }
            else if (previousScene.name == "Level_4")
            {
                SceneManager.LoadScene("Level_4");
                SceneManager.UnloadSceneAsync(previousScene.buildIndex);
            }

        }
    }

    public void wrongMove()
    {
        correctPieces -= 1;
    }
}
