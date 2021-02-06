using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReaperBehavior : MonoBehaviour
{
    //public string objectTag;
    public float speed;
    public float multiplyer;
    //public float sightDistance;
    
    //private bool movingLeft = true;

    //public Transform groundSensor;


    void Update()
    {
        //transform.Translate(Vector2.right * speed * Time.deltaTime);
        //speed *= multiplyer;

        /*int layer_mask = LayerMask.GetMask(objectTag);

        RaycastHit2D groundInfo = Physics2D.Raycast(groundSensor.position, Vector2.down, sightDistance, layer_mask);
        Debug.Log(groundInfo.collider);
        if (groundInfo.collider == true)
        {
            Debug.Log("hit");
            if (movingLeft == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingLeft = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingLeft = true;
            }
        }
        else if (groundInfo.collider == true)
        {
            Debug.Log("not hit");
        }*/
    }
}
