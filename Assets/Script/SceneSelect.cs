using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class SceneSelect : MonoBehaviour
{
    public Text ScoreLast;
    public Text ScoreBest;
    public void OnClick()
    {
        SceneManager.LoadScene("Main");
    }
    private void Update()
    {
        ScoreLast.text = "Last score: " + Convert.ToInt32(Script_Player.Score);
        ScoreBest.text = "Best score: " + PlayerPrefs.GetFloat("score");
    }
    public void Clear()
    {
        Script_Player.Score = 0f;
        PlayerPrefs.SetFloat("score", 0f);
        Debug.Log(1);
    }
}
