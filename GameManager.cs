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
    public GameObject pipes;

    public bool isReady = false;
    public bool isPlay = false;
    public bool isOver = false;

    public void ButtonClick()
    {
        ReadyGame();
    }

    public void Update()
    {
        //精妙的设计
        if (!isReady) return;
        if(isPlay) return;
        if (Input.GetMouseButton(0))
        {
            StartGame();
        }   
    }

    public void ReadyGame()
    {
        Main.GetComponent<UImanager>().hideUI();
        Tutorial.GetComponent<UImanager>().showUI();
        Score.GetComponent<UImanager>().showUI();
        isReady = true;
    }
    public void StartGame()
    {
        Tutorial.GetComponent<UImanager>().hideUI();
        player.GetComponent<playerRigidbody>().stateSwtich(true);
        isPlay = true;
    }

    public void OverGame()
    {
        Debug.Log("GameOver");
        isReady = false;
        isPlay = false;
        pipes.GetComponent<pipespawner>().stoppipe();
    }
}
