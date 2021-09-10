using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingMonster : Monster
{

    SpriteRenderer mySpriteRenderer;
    public Vector2 speed = Vector2.zero;       //Vector2 car 2D pas d axe Z  

    public float hitRange = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    virtual protected void Update()
    {

        Vector2 start;
        Vector2 direction;

        if (speed.x > 0)
        {
            mySpriteRenderer.flipX = false;
            start = (Vector2)transform.position + Vector2.right * 0.51f;
            direction = Vector2.right;
        }
        else
        {
            mySpriteRenderer.flipX = true;
            start = (Vector2)transform.position + Vector2.left * 0.51f;
            direction = Vector2.left;
        }

        Debug.DrawRay(start, direction * hitRange, Color.magenta);        //debug pour voir le rayons fictive
        RaycastHit2D hit = Physics2D.Raycast(start, direction, hitRange);

        if (hit.collider != null)
        {
            speed.x *= -1;       // quand tu vois un obstacle change 

        }
        
        // deplacement 
        Vector2 deplacement = speed * Time.deltaTime;
        transform.position += (Vector3)deplacement;         // position vector3 meme en 2D  - casting vector2 en vector3 
    }




}
