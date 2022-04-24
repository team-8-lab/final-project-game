using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuzzleManager : MonoBehaviour
{
    public GameObject PuzzleHolder;
    public GameObject[] Pieces;

    [SerializeField]
    int totalPieces = 0;

    [SerializeField]
    int correctPieces = 0;

    // Start is called before the first frame update
    void Start()
    {
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
            SceneManager.LoadScene("Tut_Level", LoadSceneMode.Additive);
        }
    }

    public void wrongMove()
    {
        correctPieces -= 1;
    }
}
