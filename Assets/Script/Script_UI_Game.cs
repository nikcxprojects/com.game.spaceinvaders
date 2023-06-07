using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Script_UI_Game : MonoBehaviour, IPointerDownHandler, IPointerUpHandler //��������� ������� ������� �������
{
    public bool Button_SetActive = false;

    public void OnPointerDown(PointerEventData eventData) //���� ������ ������
    {
        Button_SetActive = true;
    }

    public void OnPointerUp(PointerEventData eventData) //���� ��������
    {
        Button_SetActive = false;
    }
}
