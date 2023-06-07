using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusikSet : MonoBehaviour
{
    public AudioSource Audio;
    void Update()
    {
        if (PlayerPrefs.GetInt("Musik") == 1)
        {
            Audio.volume = 0f;
        }
        else
        {
            Audio.volume = 1f;
        }
    }
    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("music");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }
}
