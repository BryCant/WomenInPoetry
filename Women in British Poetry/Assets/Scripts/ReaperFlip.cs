using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class ReaperFlip : MonoBehaviour
{
    public AIPath aiPath;
    private float currScale;

    private void Start()
    {
        currScale = transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (aiPath.desiredVelocity.x >= 0.01f)
        {
            transform.localScale = new Vector3(currScale, currScale, currScale);
        }
        else if (aiPath.desiredVelocity.x <= -0.01f)
        {
            transform.localScale = new Vector3(-currScale, currScale, currScale);
        }
    }
}
