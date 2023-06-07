using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour
{
    public static Vector2 TouchPos;
    public  Vector2 Touch1;
    private Camera cam;
    void Start()
    {
        cam = Camera.main;
    }
    void Update()
    {
        Touch1 = TouchPos;
        TouchPos = cam.ScreenToWorldPoint(Input.mousePosition);
    }
}
