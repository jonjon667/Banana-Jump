﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag == "BG" || target.tag == "Platform" || target.tag == "NormalPush"
            || target.tag == "Bird")
        {
            target.gameObject.SetActive(false);
        }

    }
}
