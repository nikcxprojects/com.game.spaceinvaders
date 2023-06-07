using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject PauseMenu;
    public static bool IsPaused;
    public void OnPause ()
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;
        IsPaused = true;
    }
    public void OnExitPause()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
        IsPaused = false;
    }
    public void OnExit()
    {
        SceneManager.LoadScene("Main");
        Time.timeScale = 1f;
        IsPaused = false;
    }
    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainScene");
        IsPaused = false;
    }
}
