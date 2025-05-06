using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoretriigers : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject.Find("GameManager").GetComponent<gameManager>().GetScore();
        //Debug.Log("Score1");
    }
}
