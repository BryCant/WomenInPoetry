using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Cinemachine;

public class NavigationControls : MonoBehaviour
{
    public GameObject leftNavigate;
    public GameObject rightNavigate;
    public GameObject poetPicture;

    public GameObject followObject;

    private int pageNum = 0;

    private void Start()
    {
        Time.timeScale = 1f;
    }

    private void Update()
    {
        if (pageNum > -1)
        {
            leftNavigate.SetActive(true);
        }
        else
        {
            leftNavigate.SetActive(false);
        }

        if (pageNum < 2)
        {
            rightNavigate.SetActive(true);
        }
        else
        {
            rightNavigate.SetActive(false);
        }
    }

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

    public void StartLevel()
    {
        switch (pageNum)
        {
            case 1:
                Debug.Log("Starting Montagu Level ...");
                SceneManager.LoadScene("Montagu");
                break;
            case 2:
                Debug.Log("Starting Williams Level ...");
                SceneManager.LoadScene("Williams");
                break;
            default:
                Debug.Log("On title screen or Credit screen");
                break;
        }
    }

}
