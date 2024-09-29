using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    public GameObject Main;
    public GameObject Tutorial;
    public GameObject Score;
    public GameObject player;

    public bool isReady = false;
    public bool isPlay = false;

    public void ButtonClick()
    {
        Main.GetComponent<UImanager>().hideUI();
        Tutorial.GetComponent<UImanager>().showUI();
        Score.GetComponent<UImanager>().showUI();
        isReady = true;
    }
    public void Update()
    {
        //精妙的设计
        if (!isReady) return;
        if(isPlay) return;
        if (Input.GetMouseButton(0))
        {
            Tutorial.GetComponent<UImanager>().hideUI();
            player.GetComponent<playerRigidbody>().stateSwtich(true);

            isPlay = true;
        }
            
    }
}
