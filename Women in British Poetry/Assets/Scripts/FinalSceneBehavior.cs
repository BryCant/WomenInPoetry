using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalSceneBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GoHome());
    }

    IEnumerator GoHome()
    {
        yield return new WaitForSeconds(20);
        SceneManager.LoadScene("Gallery");
    }
}
