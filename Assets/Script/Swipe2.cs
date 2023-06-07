using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Swipe2 : MonoBehaviour, IBeginDragHandler, IDragHandler
{
    public static float RotY;
    public GameObject Lion;
    public GameObject Lion1;
    public GameObject Lion2;
    public void OnDrag(PointerEventData eventData)
    {
        if ((Mathf.Abs(eventData.delta.x)) > (Mathf.Abs(eventData.delta.y)))
        {
            if (eventData.delta.x > 0)
            {
                RotY-=5f;
            }
            else
            {
                RotY+=5f;
            }
        }
    }
    public void OnBeginDrag(PointerEventData eventData)
    {

    }
    private void Update()
    {
        Lion.transform.rotation = Quaternion.Euler(new Vector3(0, RotY, 270));
        Lion1.transform.rotation = Quaternion.Euler(new Vector3(180, RotY, 270));
        Lion2.transform.rotation = Quaternion.Euler(new Vector3(180, RotY,270));
    }
}
