using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathReaction : MonoBehaviour
{
    public Animator playerAnim;

    private bool isFrozen = false;
    private Vector3 currPos;

    private void Update()
    {
        if (isFrozen)
        {
            transform.position = currPos;
            //aiPath.enabled = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("death"))
        {
            playerAnim.SetBool("isDying", true);
            isFrozen = true;
            currPos = transform.position;
        }
    }
}
