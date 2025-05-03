using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class UIManager : MonoBehaviour
{
    public CanvasGroup canvasgroup;
    
    
    
    public void ShowUI()
    {
        canvasgroup.DOFade(1, 0.5f).onComplete = () =>
        {
            gameObject.SetActive(true);
        };

    }

    public void HideUI()
    {
        canvasgroup.DOFade(0, 0.5f).onComplete = () =>
        {
            gameObject.SetActive(false);
        };
        Debug.Log("点击");
    }
}
