using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarController : MonoBehaviour
{

    public Transform fpillars;
    public GameObject pillarPrefab;
    public gameManager gm;
    private List<GameObject> pillars = new List<GameObject>();

    public float spwanSpeed = 1f;
    public bool isSpwan = true;
    
    private void Start()
    {
        StartCoroutine(SpawnPillar());
    }

    private void Update()
    {
        //test
        SpawnPillar();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StopMove();
        }
        if(Input.GetKeyDown(KeyCode.R)) StartMove();
    }
    
    public void StartMove()
    {
        isSpwan =  true;
        foreach (GameObject pillar in pillars)
        {
            pillar.GetComponent<PillarSingle>().isMove = true;
        }
    }


    public void StopMove()
    {
        isSpwan =  false;
        foreach (GameObject pillar in pillars)
        {
            pillar.GetComponent<PillarSingle>().isMove = false;
        }
    }


	///生成一组柱子
    public void SpawnOnePillar()
    {
        GameObject pillar = GameObject.Instantiate(pillarPrefab, fpillars);
        pillar.GetComponent<PillarSingle>().RandomHeight();
        //pillar.GetComponent<PillarSingle>().isMove = true;
        pillars.Add(pillar);
    }
    IEnumerator SpawnPillar()
    {
        while (true)
        {
            yield return new WaitForSeconds(spwanSpeed);
            if (!gm.isGameStart||!isSpwan)continue;
            SpawnOnePillar();
            
        }
    }

}
