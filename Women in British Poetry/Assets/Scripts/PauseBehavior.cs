using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseBehavior : MonoBehaviour
{
    public GameObject pauseMenu;
    private bool isPaused;
    public RewardReaction playerReward;
    public DeathReaction playerDeath;

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

    }

    public void OnExit()
    {
        SceneManager.LoadScene("Gallery");
    }
}
