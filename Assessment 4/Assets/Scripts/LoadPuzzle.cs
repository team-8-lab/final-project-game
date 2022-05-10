using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(BoxCollider))]
public class LoadPuzzle : MonoBehaviour
{
    public LightController LC;

    void OnTriggerStay(Collider other)
    {
        OnMouseDown();
    }

    void OnMouseDown()
    {
        SceneManager.LoadScene("Tut_Puzzle1");
        LC.PuzzleComplete();
    }
}
