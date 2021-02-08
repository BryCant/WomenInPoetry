using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseBehavior : MonoBehaviour
{
    public GameObject pauseMenu;
    private bool isPaused;
    public RewardReaction playerReward;
    public DeathReaction playerDeath;
    
    public Button soundBtn;
    public bool isSoundOn = true;
    public Sprite soundOn;
    public Sprite soundOff;

    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
        isPaused = false;
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape) && !isPaused)
        {
            OnPause();
        }
        else if (Input.GetKeyUp(KeyCode.Escape) && isPaused)
        {
            OnContinue();
        }

    }

    public void OnPause()
    {
        if (!playerDeath.isDed)
        {
            isPaused = true;
            Time.timeScale = 0f;
            pauseMenu.SetActive(true);
        }
    }

    public void OnContinue()
    {
        if (!playerDeath.isDed)
        {
            isPaused = false;
            if(!playerReward.isScrollShowing)
                Time.timeScale = 1f;
            pauseMenu.SetActive(false);
        }
    }

    public void OnSoundToggle()
    {
        if (isSoundOn)
        {
            soundBtn.GetComponent<Image>().sprite = soundOff;
            isSoundOn = false;
        }
        else
        {
            soundBtn.GetComponent<Image>().sprite = soundOn;
            isSoundOn = true;
        }
    }

    public void OnExit()
    {
        SceneManager.LoadScene("Gallery");
    }
}
