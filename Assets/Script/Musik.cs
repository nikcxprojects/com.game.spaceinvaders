using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Musik : MonoBehaviour
{
    public static bool IsOn;
    public static bool Vibr;
    public static bool Audio;
    public Text txt;
    public Text txtvibr;
    public Text txtAudio;
    void Update()
    {
        if (!IsOn)
        {
            PlayerPrefs.SetInt("Musik", 0);
            txt.text = "Musik: On";
        }
        else
        {
            PlayerPrefs.SetInt("Musik", 1);
            txt.text = "Musik: Off";
        }
        if (!Vibr)
        {
            txtvibr.text = "Vibration: On";
        }
        else
        {
            txtvibr.text = "Vibration: Off";
        }
        if (!Audio)
        {
            txtAudio.text = "Audio: On";
        }
        else
        {
            txtAudio.text = "Audio: Off";
        }
    }
    public void OnClick()
    {
        if (IsOn)
        {
            IsOn = false;
        }
        else
        {
            IsOn = true;
        }
    }
    public void Vibration()
    {
        if (Vibr)
        {
            Vibr = false;
        }
        else
        {
            Vibr = true;
        }
    }
    public void Audio1()
    {
        if (Audio)
        {
            Audio = false;
        }
        else
        {
            Audio = true;
        }
    }
}
