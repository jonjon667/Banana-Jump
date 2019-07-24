using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow: MonoBehaviour
{
    private Transform target;

    private bool followPlayer;

    private float min_y = -2.6f;
    // Start is called before the first frame update
    void Awake()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }
    void Follow()
    {
        if (target.position.y < (transform.position.y - min_y))
        {
            followPlayer = false;
        }
        
        if(target.position.y > transform.position.y)
        {
            followPlayer = true;
        }

        if (followPlayer)
        {
            Vector3 temp = transform.position;
            temp.y = target.position.y;
            transform.position = temp;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Follow();
    }
}
