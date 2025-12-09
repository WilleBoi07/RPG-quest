using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControlls : MonoBehaviour
{
    public GameObject loadingGame;
    public void NewGame()
    {
        loadingGame.SetActive(true);
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
