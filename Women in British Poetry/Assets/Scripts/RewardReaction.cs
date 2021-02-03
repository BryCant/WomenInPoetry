using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine.UI;


public class RewardReaction : MonoBehaviour
{
    public Light2D BuzzLight;
    public GameObject msmsInfo;
    private bool touchable = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("item_reward") && touchable)
        {
            touchable = false;
            Destroy(other.gameObject);
            Debug.Log("lol");
            Thread.Sleep(100);
            Debug.Log("lipop");
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

        }
    }

}
