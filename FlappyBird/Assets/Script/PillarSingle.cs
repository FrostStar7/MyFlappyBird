using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarSingle : MonoBehaviour
{

    public float movespeed;
    public bool isMove;

    
    private void FixedUpdate()
    {
        if (isMove)
        {
            transform.Translate(-movespeed,0,0);
        }
    }

    private void Update()
    {
        
    }
    public void RandomHeight()
    {
        //1.87--2.6
        float height = UnityEngine.Random.Range(-2.6f, 1.88f);
        transform.position = new Vector3(transform.position.x, height, transform.position.z);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject.Find("GameManager").GetComponent<gameManager>().GameOver();
        Debug.Log("GameOver");
    }

    
    
}
