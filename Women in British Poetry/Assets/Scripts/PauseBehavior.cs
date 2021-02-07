using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseBehavior : MonoBehaviour
{
    public GameObject pauseMenu;

    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
    }

    public void OnPause()
    {
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
    }

    public void OnContinue()
    {
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
