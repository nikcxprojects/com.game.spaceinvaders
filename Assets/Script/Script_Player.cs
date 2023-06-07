using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;


public class Script_Player : MonoBehaviour
{
    public static float Score;
    public Text ScoreTxt1;

    public AudioSource sound;

    public GameObject Lion;
    public GameObject Karakal;
    public GameObject Hunter;
    public GameObject DeathPanel;
    public static Vector2 player;
    public float Fuel;
    public GameObject Bullet;
    public Image FillBar;
    public AudioSource Audio;

    public GameObject Left;
    Rigidbody2D rb;
    public GameObject Right;
    public float Speed;
    void Start()
    {
        Score = 0f;
        Fuel = 20;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Left.GetComponent<Script_UI_Game>().Button_SetActive && transform.position.x > -1.7f)
        {
            Speed = -2f;
        }
        else if (Right.GetComponent<Script_UI_Game>().Button_SetActive && transform.position.x < 1.7f)
        {
            Speed = 2f;
        }
        else
        {
            Speed = 0f;
        }
        rb.velocity = new Vector2(Speed, rb.velocity.y);
        Fuel -= Time.deltaTime;
        player = new Vector2(transform.position.x, transform.position.y);
        ScoreTxt1.text = "" + Convert.ToInt32(Score);
        PlayerPrefs.SetFloat("Nowscore", Score);
        if (GlobalSpeed.Car == 0)
        {
            Lion.SetActive(true);
            Karakal.SetActive(false);
            Hunter.SetActive(false);
        }
        if (GlobalSpeed.Car == 1)
        {
            Lion.SetActive(false);
            Karakal.SetActive(false);
            Hunter.SetActive(true);
        }
        if (GlobalSpeed.Car == 2)
        {
            Lion.SetActive(false);
            Karakal.SetActive(true);
            Hunter.SetActive(false);
        }
        if (Fuel <= 0f)
        {
            DeathPanel.SetActive(true);
            SceneManager.LoadScene("Main");
            if (Score > PlayerPrefs.GetFloat("score"))
            {

                PlayerPrefs.SetFloat("score", Score);
            }
        }
        else
        {
            if (Pause.IsPaused == false)
            {
            Time.timeScale = 1f;
            }
            else
            {
                Time.timeScale = 0f;
            }

        }
        FillBar.fillAmount = Fuel / 20f;
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            SceneManager.LoadScene("Main");
            if (!Musik.Vibr)
            {
                Handheld.Vibrate();
            }
        }
        if (collision.gameObject.tag == "Fuel")
        {
            Fuel = 20f;
            Destroy(collision.gameObject);
            if (!Musik.Vibr)
            {
                Handheld.Vibrate();
            }
        }
    }
    public void Fire()
    {
        if (!Musik.Audio)
        {
            Audio.Play();
        }
        Instantiate(Bullet, transform.position, Quaternion.identity);
    }
}