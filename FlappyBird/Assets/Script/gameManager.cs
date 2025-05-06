using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public GameObject tutorTap;
    public GameObject score;
    public GameObject mainMenu;
    public GameObject bird;
    
    public Text scoreText;
    
    public bool isGameReady=false;
    public bool isGameStart=false;

    public void PlayBtnClick()
    {
        mainMenu.GetComponent<UIManager>()?.HideUI();
        tutorTap.GetComponent<UIManager>()?.ShowUI();
        score.GetComponent<UIManager>()?.ShowUI();
        isGameReady = true;

    }

    private void Update()
    {
        if (isGameReady&&!isGameStart)
        {
            if (Input.GetMouseButtonDown(0))
            {
                tutorTap.GetComponent<UIManager>()?.HideUI();
                bird.GetComponent<birdController>()?.ChangeState(true);
                isGameStart = true;
                
            }
            return;
        }
    }

    public void GameOver()
    {
        isGameStart = false;
        GameObject.Find("PillarController").GetComponent<PillarController>().StopMove();
        GameObject.Find("Backgrounds").GetComponent<bgController>().speed = 0;
        GameObject.Find("land").GetComponent<bgController>().speed = 0;
    }

    public void GetScore()
    {
        //scoreText.text = (int.Parse(scoreText.text) + 1).ToString(); 
        //Debug.Log("Score");
        score.GetComponent<Text>().text = (int.Parse(scoreText.text) + 1).ToString();
    }
    
    
}
