using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class player : MonoBehaviour
{
    public Rigidbody2D Rigidbody2D;
    public float speed = 0f;
    public float jumpParameter = 0.5f;
    public float gravity = -9.8f/2;

    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Mousebyself();
    }
    
    void Mousebyself()
    {
        if (Input.GetMouseButtonDown(0))
        {
            speed += jumpParameter;
        }
        speed += Time.deltaTime * gravity;
        Debug.Log(speed);
        transform.position = new Vector3(0, speed * Time.deltaTime + transform.position.y, 0);
    }
}
