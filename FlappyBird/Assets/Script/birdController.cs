using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class birdController : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public Animator animator;
    public gameManager gamemanager;
    public Transform birdimg;
    public float addSpeed;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)&&gamemanager.isGameStart)
        {
            Fly();
            //Debug.Log("速度加");
        }

        birdimg.transform.DORotateQuaternion(Quaternion.Euler(0, 0, rb2d.velocity.y * 7f), 0.5f);
        //birdimg.transform.rotation = Quaternion.Euler(0,0,rb2d.velocity.y*3.7f);
    }


    public void Fly()
    {
        rb2d.velocity = new Vector2(0, addSpeed);
    }
    
    
    
    public void ChangeState(bool isfly)
    {
        if (isfly)
        {
            animator.SetInteger("state",1);
            rb2d.simulated = true;
        }
        else
        {
            animator.SetInteger("state", 0);
            rb2d.simulated = false;
        }
    }




}
