using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SelectCar : MonoBehaviour
{
    public static float NowCar;
    public static float SelectedCar;
    public GameObject Lion;
    public GameObject Karakal;
    public GameObject Hunter;
    private void Start()
    {
        NowCar = SelectedCar;
        Swipe2.RotY = 90;
    }
    void Update()
    {
        if (NowCar == 0)
        {
            Lion.SetActive(true);
            Karakal.SetActive(false);
            Hunter.SetActive(false);
        }
        if (NowCar == 1)
        {
            Lion.SetActive(false);
            Karakal.SetActive(false);
            Hunter.SetActive(true);
        }
        if (NowCar == 2)
        {
            Lion.SetActive(false);
            Karakal.SetActive(true);
            Hunter.SetActive(false);
        }
    }
    public void Right()
    {
        if (NowCar < 2)
        {
            NowCar += 1;
            Swipe2.RotY = 90;
        }
    }
    public void Left()
    {
        if (NowCar > 0)
        {
            NowCar -= 1;
            Swipe2.RotY = 90;
        }
    }
    public void Select()
    {
        SelectedCar = NowCar;
        SceneManager.LoadScene("Main");
    }
}
