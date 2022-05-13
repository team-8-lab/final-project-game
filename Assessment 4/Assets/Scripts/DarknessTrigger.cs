using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DarknessTrigger : MonoBehaviour
{

    public GameObject blackOutSquare;

    [SerializeField]
    private GameObject losingPanel;

    public bool unlockCursor = false;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Capsule")
        {
            StartCoroutine(FadeBlackOutSquare());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Capsule")
        {
            StopAllCoroutines();
            StartCoroutine(FadeBlackOutSquare(false));
        }
    }

    public IEnumerator FadeBlackOutSquare(bool fadeToBlack = true, int fadeSpeed = 1)
    {
        Color objectColor = blackOutSquare.GetComponent<Image>().color;
        float fadeAmount;

        if (fadeToBlack)
        {
            while (blackOutSquare.GetComponent<Image>().color.a < 1)
            {
                fadeAmount = objectColor.a + ((float)fadeSpeed/5 * Time.deltaTime);

                objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
                blackOutSquare.GetComponent<Image>().color = objectColor;
                yield return null;
            }

            Destroy(GameObject.Find("UI_KeyHolder_Canvas"));
            LoseGame();
        }
        else
        {
            while (blackOutSquare.GetComponent<Image>().color.a > 0)
            {
                fadeAmount = objectColor.a - ((float)fadeSpeed/2 * Time.deltaTime);

                objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
                blackOutSquare.GetComponent<Image>().color = objectColor;
                yield return null;
            }
        }
    }

    public void LoseGame()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        losingPanel.SetActive(true);
        unlockCursor = true;
    }

     public void MainMenu()
    {
        SceneManager.LoadScene("Main_Menu");
        losingPanel.SetActive(false);
        unlockCursor = false;
    }
}
