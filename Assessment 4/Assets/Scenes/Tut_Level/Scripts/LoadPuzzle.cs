using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(BoxCollider))]
public class LoadPuzzle : MonoBehaviour
{

<<<<<<< HEAD
=======
    public LightController LC;

>>>>>>> Lights
    void OnTriggerStay(Collider other)
    {
        OnMouseDown();
    }

    void OnMouseDown()
    {
        SceneManager.LoadScene("Tut_Puzzle1");
<<<<<<< HEAD
=======
        LC.PuzzleComplete();
>>>>>>> Lights
    }
}
