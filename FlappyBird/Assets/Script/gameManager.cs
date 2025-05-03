using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public GameObject tutorMenu;
    public GameObject mainMenu;


    public void PlayBtnClick()
    {
        mainMenu.GetComponent<UIManager>()?.HideUI();
        tutorMenu.GetComponent<UIManager>()?.ShowUI();
        
        
        

    }
    
    
    
    
    
}
