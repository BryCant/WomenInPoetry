using System.Collections;
using System.Collections.Generic;
//using System.Numerics;
using UnityEngine;

public class CursorBehavior : MonoBehaviour
{
    //public float timeBtwnSpwn = 0.1f;
   // public GameObject trailEffect;
    public float mouseSensitivity = 1f;


    // Update is called once per frame
    void Update()
    {
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        cursorPos.x *= mouseSensitivity;
        cursorPos.y *= mouseSensitivity;
        transform.position = cursorPos;

        //if(timeBtwnSpwn <= 0)
        //{
        //    Instantiate(trailEffect, cursorPos, Quaternion.identity);
        //    timeBtwnSpwn = 0.1f;
        //}
        //else
        //{
        //    timeBtwnSpwn -= Time.deltaTime;
        //}
    }
}
