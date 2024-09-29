using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;

public class UImanager : MonoBehaviour
{
    // Start is called before the first frame update
    public CanvasGroup canvasGroup;
    public float time = 0.5f;
    public void showUI()
    {
        canvasGroup.DOFade(1, time);
    }
    public void hideUI() 
    {
        canvasGroup.DOFade(0,time).onComplete = ()=> 
        { 
            gameObject.SetActive(false);
        };
    }
}
