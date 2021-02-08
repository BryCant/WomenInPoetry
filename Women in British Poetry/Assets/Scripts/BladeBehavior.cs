using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BladeBehavior : MonoBehaviour
{
    private Transform target;
    private Vector3 startingPos;
    public Transform bladeGraphics;

    public float fallProximity = 1;
    public float resetTime = 1;
    private bool isBlading = false;
    public bool debug = false;

    public Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        startingPos = bladeGraphics.position;
        rb.simulated = false;
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Vector2.Distance(transform.position, target.position) < fallProximity && !isBlading)
        {
            isBlading = true;
            rb.simulated = true;
            StartCoroutine(FallAndReset());
        }
        if(debug)
            Debug.Log(Vector2.Distance(transform.position, target.position));
    }

    IEnumerator FallAndReset()
    {
        //Physics2D.IgnoreLayerCollision(8, 9, true);
        yield return new WaitForSeconds(resetTime);
        rb.simulated = false;
        yield return new WaitForSeconds(1.5f);
        bladeGraphics.position = startingPos;
        yield return new WaitForSeconds(10.5f);
        isBlading = false;
        //Physics2D.IgnoreLayerCollision(8, 9, false);

    }
}
