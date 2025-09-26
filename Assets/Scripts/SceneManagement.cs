using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class Scenes : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void OnApplicationQuit()
    {
        Application.Quit();
        Debug.Log("Game is exiting");
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("GameScene");
    }
}

