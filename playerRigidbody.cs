using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class playerRigidbody : MonoBehaviour
{
    private Rigidbody2D birdrb;

    public GameObject GameManager; 
    public Vector3 jump = new Vector3(0,5,0);
    private float rtparam = 4.0f;

    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        birdrb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        fly();
    }

    public void stateSwtich(bool isfly)
    {
        if (isfly)
        {
            animator.SetInteger("state", 1);
            birdrb.simulated = true;
        }
        else
        {
            animator.SetInteger("state", 0);
        }
    }
    public void fly()
    {
        if (!GameManager.GetComponent<GameManager>().isPlay) return;

        if (Input.GetMouseButtonDown(0))
        {
            birdrb.velocity = jump;
        }
        transform.GetChild(0).transform.rotation = Quaternion.Euler(0, 0, birdrb.velocity.y * rtparam);
    }
}
