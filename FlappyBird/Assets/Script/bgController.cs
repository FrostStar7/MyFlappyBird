using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgController : MonoBehaviour
{
    public float speed;
    public Vector3 startPos;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -7.7)
        {
            transform.position = startPos;
        }
        transform.Translate(-speed,0,0);
    }
}
