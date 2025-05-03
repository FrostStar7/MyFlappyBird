using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdController : MonoBehaviour
{
    public Rigidbody2D rb2d;
    
    
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb2d.velocity = new Vector2(0, 7);
        }
    }
}
