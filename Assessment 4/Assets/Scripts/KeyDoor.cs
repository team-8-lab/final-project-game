using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyDoor : MonoBehaviour
{
    [SerializeField]
    private Key.KeyType keyType;

    [SerializeField]
    private GameObject winningPanel;

    public Key.KeyType GetKeyType()
    {
        return keyType;
    }

    public void OpenDoor()
    {
        if(GetKeyType() == Key.KeyType.WallKey)
        {
            this.gameObject.SetActive(false);
        }
        else
        {
            WinGame();
        }
        
        
    }

    public void WinGame()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        winningPanel.SetActive(true);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main_Menu");
        winningPanel.SetActive(false);
    }
}
