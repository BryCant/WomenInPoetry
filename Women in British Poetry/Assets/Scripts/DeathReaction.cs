using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathReaction : MonoBehaviour
{
    public Animator playerAnim;

    public bool isDed = false;
    private Vector3 currPos;

    public string currScene;

    public GameObject gameOverScreen;

    private void Start()
    {
        gameOverScreen.SetActive(false);
    }

    private void Update()
    {
        if (isDed)
        {
            transform.position = currPos;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("death"))
        {
            playerAnim.SetBool("isDying", true);
            isDed = true;
            currPos = transform.position;
            StartCoroutine(GameOver());
        }
    }

    IEnumerator GameOver()
    {
        yield return new WaitForSeconds(2.5f);
        gameOverScreen.SetActive(true);
    }

    public void DeathExit()
    {
        SceneManager.LoadScene("Gallery");
    }

    public void DeathReplay()
    {
        SceneManager.LoadScene(currScene);
    }

}
