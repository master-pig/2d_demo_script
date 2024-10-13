using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisiondetector : MonoBehaviour
{
    

    void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject gamemamager = GameObject.Find("GameManager");
        gamemamager.GetComponent<GameManager>().OverGame();
    }
}
