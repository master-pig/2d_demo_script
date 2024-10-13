using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class pipemover : MonoBehaviour
{
    public float speed = 0.05f;
    public bool canmoved = true;

    void FixedUpdate()
    {
        if (!canmoved) return;
        transform.Translate(-speed, 0, 0);
    }
    public void Randomposition()
    {
        float position_y = UnityEngine.Random.Range(-2.0f, 2.0f);
        transform.position = new Vector3(transform.position.x,position_y,0);
    }
}
