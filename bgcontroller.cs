using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class bgcontroller : MonoBehaviour
{
    private Vector3 startPos;
    public float bgvelocity = -0.005f;
    public float length = -8.2f;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < length) 
        {
            transform.position = startPos;
        }
        transform.Translate(bgvelocity, 0, 0);
    }
}
