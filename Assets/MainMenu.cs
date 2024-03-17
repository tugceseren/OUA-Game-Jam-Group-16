using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void ExitGame() 
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    public void CreditGame()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadSceneAsync(1);
    }
}

