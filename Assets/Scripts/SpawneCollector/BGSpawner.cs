using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGSpawner : MonoBehaviour
{
    GameObject[] backgrounds;
    private float height;
    private float max_y_Pos;

    private void Awake()
    {
        backgrounds = GameObject.FindGameObjectsWithTag("BG");
    }
    void Start()
    {
        height = backgrounds[0].GetComponent<BoxCollider2D>().bounds.size.y;
        max_y_Pos = backgrounds[0].transform.position.y;

        for(int i = 1; i < backgrounds.Length; i++)
        {
            if (backgrounds[i].transform.position.y > max_y_Pos)
            {
                max_y_Pos = backgrounds[i].transform.position.y;

            }

        }
    }

    private void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag == "BG")
        {
            if(target.transform.position.y >= max_y_Pos)
            {
                Vector3 temp = target.transform.position;

                for (int i =0 ; i < backgrounds.Length; i++){
                    if (!backgrounds[i].activeInHierarchy)
                    {
                        temp.y += height;
                        backgrounds[i].transform.position = temp;
                        backgrounds[i].SetActive(true);
                        max_y_Pos = temp.y;
                    }
                }
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
