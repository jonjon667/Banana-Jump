using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript: MonoBehaviour
{
    [SerializeField]
    private GameObject banana, bananas;

    [SerializeField]
    private Transform spawn_Point;

    // Start is called before the first frame update
    void Start()
    {
        GameObject newBanana = null;

        if(Random.Range(0,10) > 3)
        {
            newBanana = Instantiate(banana, spawn_Point.position, Quaternion.identity);
        }
        else
        {
            newBanana = Instantiate(bananas, spawn_Point.position, Quaternion.identity);
        }
        newBanana.transform.parent = transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
