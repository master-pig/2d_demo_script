using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipespawner : MonoBehaviour
{

    public GameObject pipeprefab;
    public GameObject gamemamager;
    public float interval = 1.6f;
    public bool canmoveds = true;

    private List<GameObject> pipelist = new List<GameObject>();

    void Start()
    {
        StartCoroutine(timer());
    }

    public void spawnpipe()
    {
        GameObject pipe = GameObject.Instantiate(pipeprefab);
        pipe.GetComponent<pipemover>().Randomposition();
        pipelist.Add(pipe);
    }
    /// <summary>
    /// Í£Ö¹Öù×ÓÒÆ¶¯,Ë³±ãÔÝÍ£Éú³É
    /// </summary>
    public void stoppipe()
    {
        foreach (GameObject pipe in pipelist)
        {
            pipe.GetComponent<pipemover>().canmoved = false;
        }
        canmoveds = false;  
    }

    IEnumerator timer()
    {
        while (true)
        {
            yield return new WaitForSeconds(interval);
            if (!gamemamager.GetComponent<GameManager>().isPlay) continue;
            if (!canmoveds) continue;
            spawnpipe();
        }
    }


}
