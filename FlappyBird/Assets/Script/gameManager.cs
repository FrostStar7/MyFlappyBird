using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;


public class gameManager : MonoBehaviour
{
    public GameObject tutorTap;
    public GameObject mainMenu;
    public GameObject bird;
    public GameObject over;
    public GameObject reStart;
    
    public GameObject score;
    public GameObject newimg;
    public Text newScoreText;
    public Text bestScoreText;
    public Text scoreText;

    public List<Sprite> Medels;
    public Image medelimg;
    
    public bool isGameReady;
    public bool isGameStart;

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

    private void OnDisable()
    {
        DOTween.KillAll();
    }

    public void GameOver()
    {
        isGameStart = false;
        GameObject.Find("PillarController").GetComponent<PillarController>().StopMove();
        GameObject.Find("Backgrounds").GetComponent<bgController>().speed = 0;
        GameObject.Find("land").GetComponent<bgController>().speed = 0;
        bird.GetComponent<Rigidbody2D>().simulated = false;
        over.GetComponent<UIManager>().ShowUI();
        
        int scores = int.Parse(scoreText.text);
        if (PlayerPrefs.GetInt("bestscore") < scores)
        {
            PlayerPrefs.SetInt("bestscore", scores);
            newimg.SetActive(true);
        }
        
        newScoreText.text = scores.ToString();
        bestScoreText.text = PlayerPrefs.GetInt("bestscore").ToString();

        if (scores >= 2)
        {
            medelimg.sprite = Medels[0];
        }
        else if(scores >= 8)
        {
            medelimg.sprite = Medels[1];
        }
        else if (scores >= 16)
        {
            medelimg.sprite = Medels[2];
        }
        else if (scores >= 32)
        {
            medelimg.sprite = Medels[3];
        }
        else
        {
            medelimg.gameObject.SetActive(false);
        }
        
    }

    public void Restart()
    {
        SceneManager.LoadScene("GameScene");
    }
    
    public void GetScore()
    {
        if(!isGameStart)return;
        //scoreText.text = (int.Parse(scoreText.text) + 1).ToString(); 
        //Debug.Log("Score");
        score.GetComponent<Text>().text = (int.Parse(scoreText.text) + 1).ToString();
    }
    
    
}
