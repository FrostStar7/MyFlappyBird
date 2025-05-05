using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public GameObject tutorMenu;
    public GameObject mainMenu;
    public GameObject bird;
    public bool isGameReady=false;
    public bool isGameStart=false;

    public void PlayBtnClick()
    {
        mainMenu.GetComponent<UIManager>()?.HideUI();
        tutorMenu.GetComponent<UIManager>()?.ShowUI();
        isGameReady = true;

    }

    private void Update()
    {
        if (isGameReady&&!isGameStart)
        {
            if (Input.GetMouseButtonDown(0))
            {
                tutorMenu.GetComponent<UIManager>()?.HideUI();
                bird.GetComponent<birdController>()?.ChangeState(true);
                isGameStart = true;
            }
            return;
        }
    }
    
    
    
}
