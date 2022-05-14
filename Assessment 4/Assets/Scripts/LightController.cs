using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LightController : MonoBehaviour
{
    public GameObject[] lamps;
    public GameObject[] lampsOff;
    public GameObject[] darknessMesh;
    private string currentLevel;
    private bool start;

    void Start()
    {
        start = true;
        PuzzleComplete(false);
        currentLevel = SceneManager.GetActiveScene().name;
        for (int i = 0; i < darknessMesh.Length; i++)
        {
            darknessMesh[i].transform.position += new Vector3(0, 300, 0);
        }
    }

    public void PuzzleComplete(bool toggle)
    {
        if(toggle)
        {
            //Turn on lamps
            for (int i = 0; i < lamps.Length; i++)
            {
                lamps[i].SetActive(true);
                toggle = false;
            }
            for (int i = 0; i < lampsOff.Length; i++)
            {
                lampsOff[i].SetActive(false);
            }
            for (int i = 0; i < darknessMesh.Length; i++)
            {
                darknessMesh[i].transform.position += new Vector3(0, 300, 0);
            }
            if (start)
            {
                start = false;
            }
        }
        else
        {
            //Turn off lamps
            for (int i = 0; i < lampsOff.Length; i++)
            {
                lampsOff[i].SetActive(true);
                toggle = true;
            }
            for (int i = 0; i < lamps.Length; i++)
            {
                lamps[i].SetActive(false);
            }
            for (int i = 0; i < darknessMesh.Length; i++)
            {
                darknessMesh[i].transform.position -= new Vector3(0, 300, 0);
            }
        }
    }
}
