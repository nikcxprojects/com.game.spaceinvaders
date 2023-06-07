using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalSpeed : MonoBehaviour
{
    public static float Car;
    public static float Speed;
    void Start()
    {
        Speed =1f;
        Car = SelectCar.SelectedCar;
    }
    private void Update()
    {
        if (Car == 0)
        {
            if (Speed < 5)
            {
                Speed += Time.deltaTime;
            }
        }
        if (Car == 1)
        {
            if (Speed < 6)
            {
                Speed += Time.deltaTime;
            }
        }
        if (Car == 2)
        {
            if (Speed < 8)
            {
                Speed += Time.deltaTime;
            }
        }
        Script_Player.Score += Time.deltaTime * Speed;
    }
}
