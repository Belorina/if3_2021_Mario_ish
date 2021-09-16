using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingMonster : Monster
{

    SpriteRenderer mySpriteRenderer;

    [Tooltip("Monster speed")]
    public Vector2 speed = Vector2.zero;       //Vector2 car 2D pas d axe Z  

    [Tooltip("Distance obstacle detection, equals or less then:")]
    public float hitRange = 0.1f;

    private Animator animator;      // NULL

    // Start is called before the first frame update
    void Start()
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();        // si il ny a pas d animator = return NULL
    }

    // Update is called once per frame
    virtual protected void Update()
    {

        Vector2 start;
        Vector2 direction;

        if (speed.x > 0)
        {
            if (animator != null)
            {
                animator.SetBool("right", false);       // si y a animator right = false / lancer lanimation
            }
            else
            {
                mySpriteRenderer.flipX = false;     // si l'animation est NULL, on continue avec les flip 
            }
            start = (Vector2)transform.position + Vector2.right * 0.51f;
            direction = Vector2.right;
        }
        else
        {
            if (animator != null)                           // if there is an animator 
            {
                animator.SetBool("right", true);            // set animation bool condition to true (because going to left) 
            }
            else                                            // no animator ? 
            {
                mySpriteRenderer.flipX = true;              // "continue" sprite flip 
            }
            start = (Vector2)transform.position + Vector2.left * 0.51f;
            direction = Vector2.left;
        }

        Debug.DrawRay(start, direction * hitRange, Color.magenta);        //debug pour voir le rayons fictive
        RaycastHit2D hit = Physics2D.Raycast(start, direction, hitRange);

        if (hit.collider != null && !hit.transform.CompareTag("Player"))
        {
            speed.x *= -1;       // quand tu vois un obstacle change 

        }

        // deplacement 
        Vector2 deplacement = speed * Time.deltaTime;
        transform.position += (Vector3)deplacement;         // position vector3 meme en 2D  - casting vector2 en vector3 
    }




}
