using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript: MonoBehaviour
{
    private Rigidbody2D myBody;

    public float moveSpeed = 2f;

    public float normal_push = 10f;
    public float extra_push = 13f;

    private int push_count;

    private bool player_Died;
    private bool initial_Push;


    // Start is called before the first frame update
    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "ExtraPush")
        {
            if (!initial_Push)
            {
                initial_Push = true;
                myBody.velocity = new Vector2(myBody.velocity.x, 18f);

                target.gameObject.SetActive(false);

                return;
            }
        }
    } 
}
