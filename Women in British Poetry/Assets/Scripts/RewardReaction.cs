using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine.UI;


public class RewardReaction : MonoBehaviour
{
    public Image[] scrolls;
    public Sprite scrollEmpty;
    public Sprite scrollFull;
    private int scrollCount = 0;

    public Light2D BuzzLight;
    public GameObject msmsInfo;
    private bool touchable = true;

    private void Start()
    {
        foreach(Image scroll in scrolls)
        {
            scroll.GetComponent<Image>().sprite = scrollEmpty;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("scroll") && touchable)
        {
            Destroy(other.gameObject);
            touchable = false;

            scrollCount++;

            switch (scrollCount)
            {
                case 1:
                    scrolls[1].GetComponent<Image>().sprite = scrollFull;
                    break;
            }

            if (msmsInfo.activeSelf)
            {
                msmsInfo.SetActive(false);
            }
            else
            {
                msmsInfo.SetActive(true);
            }
            BuzzLight.intensity += .2f;
            //msmsInfo.SetActive(true);
            touchable = true;

        }
    }

}
