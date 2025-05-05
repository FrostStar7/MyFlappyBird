using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarController : MonoBehaviour
{

    public Transform pillars;
    public GameObject pillarPrefab;
    
    
    
    
    public void StartMove()
    {
        
    }


    public void StopMove()
    {
        
    }

    public void SpawnOnePillar()
    {
        GameObject pillar = GameObject.Instantiate(pillarPrefab, pillars);
        pillar.GetComponent<PillarSingle>().RandomHeight();
        //pillar.GetComponent<PillarSingle>().isMove = true;
    }


    private void Update()
    {
        //test
        if (Input.GetKeyDown(KeyCode.A))
        {
            SpawnOnePillar();
        }
    }
}
