using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PoetFrameBehavior : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private void Start()
    {
        Debug.Log("we in ssdis");

    }

    private void OnMouseEnter()
    {
        Debug.Log("we in ssdis");

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Mouse enter");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Mouse exit");
    }
}
