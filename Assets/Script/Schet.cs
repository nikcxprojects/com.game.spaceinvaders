using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Schet : MonoBehaviour
{
    public Sprite Schet1;
    public Sprite Schet2;
    public Sprite Schet3;
    public GameObject NameLion;
    public Text txt;
    void Update()
    {
        if (SelectCar.NowCar == 0f)
        {
            GetComponent<Image>().sprite = Schet1;
            txt.text = "Scorpio";
        }
        if (SelectCar.NowCar == 1f)
        {
            GetComponent<Image>().sprite = Schet2;
            txt.text = "Sagittarius";
        }
        if (SelectCar.NowCar == 2f)
        {
            GetComponent<Image>().sprite = Schet3;
            txt.text = "Capricorn";
        }
    }
}
