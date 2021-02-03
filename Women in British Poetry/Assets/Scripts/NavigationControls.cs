using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Cinemachine;

public class NavigationControls : MonoBehaviour
{
    public Button leftNavigate;
    public Button rightNavigate;

    public GameObject followObject;

    private int pageNum = 0;


    public void MoveCamLeft()
    {
        if (pageNum > -1)
        {
            pageNum--;
            Debug.Log("PageNum:" + pageNum.ToString());
            followObject.transform.position += new Vector3(-19, 0);
        }
    }

    public void MoveCamRight()
    {
        if (pageNum < 2)
        {
            pageNum++;
            Debug.Log("PageNum:" + pageNum.ToString());
            followObject.transform.position += new Vector3(19, 0);
        }
    }
}
