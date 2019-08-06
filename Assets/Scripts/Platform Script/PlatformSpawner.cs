using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public static PlatformSpawner instance;
    // Start is called before the first frame update
    [SerializeField]
    private GameObject left_Platform, right_Platform;
    private float left_X_Min = -4.4f, left_X_Max = -2.8f, right_X_Min = 4.4f, right_X_Max = 2.8f;
    private float y_threshold = 2.2f;
    private float last_Y;
    public int spawn_Count = 8;
    private int platform_Spawned;

    [SerializeField]
    private Transform platform_Parent;
    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }

    }
    private void Start()
    {
        last_Y = transform.position.y;
        SpawnPlatforms();
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnPlatforms()
    {
        Vector2 temp = Vector2.zero;
        GameObject newPlatform = null;

        for(int i = 0; i < spawn_Count; i++)
        {
            temp.y = last_Y;
            if((platform_Spawned) % 2 == 0)
            {
                temp.x = Random.Range(left_X_Min, left_X_Max);
                newPlatform = Instantiate(right_Platform, temp, Quaternion.identity);
            }
            else
            {
                temp.x = Random.Range(right_X_Min, right_X_Max);
                newPlatform = Instantiate(left_Platform, temp, Quaternion.identity);
            }
            newPlatform.transform.parent = platform_Parent;

            last_Y += y_threshold;
            platform_Spawned++;
        }
    }
}
