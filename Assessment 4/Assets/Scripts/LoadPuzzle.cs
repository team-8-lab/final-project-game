using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(BoxCollider))]
public class LoadPuzzle : MonoBehaviour
{

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
        SceneManager.LoadScene("Tut_Puzzle", LoadSceneMode.Additive);
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
