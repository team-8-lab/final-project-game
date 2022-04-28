using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    public GameObject[] lamps;
    public GameObject[] lampsOff;
    public bool lightToggle = false;

    void Start()
    {
        //Add all lamps to the arrays
        lamps = GameObject.FindGameObjectsWithTag("Puzzle1Light");
        lampsOff = GameObject.FindGameObjectsWithTag("Puzzle1LightOFF");

        PuzzleComplete();
    }

    public void PuzzleComplete()
    {
        if(lightToggle)
        {
            for (int i = 0; i < lamps.Length; i++)
            {
                lamps[i].SetActive(true);
                lampsOff[i].SetActive(false);
                lightToggle = false;
            }
        }
        else
        {
            for (int i = 0; i < lampsOff.Length; i++)
            {
                lamps[i].SetActive(false);
                lampsOff[i].SetActive(true);
                lightToggle = true;
            }
        }
    }
}
