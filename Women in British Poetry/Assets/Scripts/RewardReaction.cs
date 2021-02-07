using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine.UI;


public class RewardReaction : MonoBehaviour
{
    // Scroll Bar
    public Image[] scrolls;
    public Sprite scrollEmpty;
    public Sprite scrollFull;
    private int scrollCount = 0;


    public GameObject[] scrollContents;
    private bool touchable = true;

    private void Start()
    {
        foreach(Image scroll in scrolls)
        {
            scroll.GetComponent<Image>().sprite = scrollEmpty;
        }
    }

    private void Update()
    {
        if(scrollContents[scrollCount].activeSelf)
        {
            if (Input.GetKeyDown("space") || Input.GetKeyDown("down"))
            {
                OnContinue();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("scroll") && touchable)
        {
            Destroy(other.gameObject);
            touchable = false;

            scrolls[scrollCount].GetComponent<Image>().sprite = scrollFull;
            Time.timeScale = 0f;
            scrollContents[scrollCount].SetActive(true);
            StartCoroutine(DelayTouchable());
        }
    }

    IEnumerator DelayTouchable()
    {
        yield return new WaitForSeconds(1);
        touchable = true;
    }

    public void OnContinue()
    {
        Time.timeScale = 1f;
        scrollContents[scrollCount].SetActive(false);
        scrollCount++;
    }

}
