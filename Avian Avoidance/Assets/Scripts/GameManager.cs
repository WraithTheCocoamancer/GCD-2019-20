using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("AvianAvoidance");
    }
    public void EndGame()
    {
        SceneManager.LoadScene("Game Over");
    }
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void ToControls()
    {
        SceneManager.LoadScene("Controls");
    }

    public void WinGame()
    {
        SceneManager.LoadScene("Win Game");
    }
}


