using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrivacePol : MonoBehaviour
{
    private void Start()
    {
        if (PlayerPrefs.GetInt("int") == 1)
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
        }
    }
    public void OnPolicy()
    {
        Application.OpenURL("https://docs.google.com/document/d/1LJAXifbg5wZvFuTzvYJqWFpsU3pt8nwQyQErmlhNiU0/edit?usp=sharing");
    }
    public void OnAccept()
    {

        PlayerPrefs.SetInt("int", 1);
        Debug.Log(PlayerPrefs.GetInt("int"));
        gameObject.SetActive(false);
    }
    public void OnDecline()
    {
        Application.Quit();
    }
}
