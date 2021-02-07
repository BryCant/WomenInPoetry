using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseBehavior : MonoBehaviour
{
    public GameObject pauseMenu;
    private bool isPaused;

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
        isPaused = true;
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
    }

    public void OnContinue()
    {
        isPaused = false;
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
    }

    public void OnSoundToggle()
    {

    }

    public void OnExit()
    {

    }
}
