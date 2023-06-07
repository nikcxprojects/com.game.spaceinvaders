using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public void CarSelect()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("LionSelect");

    }
    public void StartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainScene");
    }
    public void Score()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Score");
    }
    public void MenuSelect()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main");
    }
    public void Setings()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Settings");
    }
}
