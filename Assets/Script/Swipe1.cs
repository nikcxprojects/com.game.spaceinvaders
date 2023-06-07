using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Swipe1 : MonoBehaviour, IBeginDragHandler, IDragHandler
{
    public GameObject obj;
    public void OnDrag(PointerEventData eventData)
    {
        if ((Mathf.Abs(eventData.delta.x)) > (Mathf.Abs(eventData.delta.y)))
        {
            if (eventData.delta.x > 0)
            {
            }
            else
            {
            }
        }
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
    }
}
