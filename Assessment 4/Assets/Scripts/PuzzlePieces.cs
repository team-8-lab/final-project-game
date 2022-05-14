using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzlePieces : MonoBehaviour
{
    float[] rotations = { 0, 90, 180, 270 };

    public float[] correctRotation;
    int PossibleRotations = 1;

    [SerializeField]
    bool isPlaced = false;

    PuzzleManager puzzleManager;

    private void Awake()
    {
        puzzleManager = GameObject.Find("PuzzleManager").GetComponent<PuzzleManager>();
    }

    private void Start()
    {
        PossibleRotations = correctRotation.Length;
        int rand = Random.Range(0, rotations.Length);
        transform.eulerAngles = new Vector3(0, 0, rotations[rand]);

        if (PossibleRotations > 1)
        {
            if (transform.eulerAngles.z == correctRotation[0] || transform.eulerAngles.z == correctRotation[1])
            {
                isPlaced = true;
                puzzleManager.correctMove();
            }
        }
        else
        {
            if (transform.eulerAngles.z == correctRotation[0])
            {
                isPlaced = true;
                puzzleManager.correctMove();
            }
        }
        
    }

    private void OnMouseDown()
    {
        transform.Rotate(new Vector3(0, 0, 90));
        transform.eulerAngles = new Vector3(0, 0, Mathf.Round(transform.eulerAngles.z));

        if (PossibleRotations > 1) {
            if (transform.eulerAngles.z == correctRotation[0] || transform.eulerAngles.z == correctRotation[1] && isPlaced == false)
            {
                isPlaced = true;
                puzzleManager.correctMove();
            }
            else if (isPlaced == true)
            {
                isPlaced = false;
                puzzleManager.wrongMove();
            } 
        }
        else
        {
            if (transform.eulerAngles.z == correctRotation[0] && isPlaced == false)
            {
                isPlaced = true;
                puzzleManager.correctMove();
            }
            else if (isPlaced == true)
            {
                isPlaced = false;
                puzzleManager.wrongMove();
            }
        }
    }
}