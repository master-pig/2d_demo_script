using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scorecalculator : MonoBehaviour
{
    public Text score;

    private GameObject gamemanager;
    private void Start()
    {
        gamemanager = GameObject.Find("GameManager");
        StartCoroutine(scoresum());
    }

    IEnumerator scoresum()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.2f);
            if (gamemanager.GetComponent<GameManager>().isPlay)
            {
                score.text = (int.Parse(score.text) + 1).ToString();
            }
        }
    }
}
