using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingMonster : Monster
{

    SpriteRenderer mySpriteRenderer;
    public Vector2 speed = Vector2.zero;       //Vector2 car 2D pas d axe Z  

    // Start is called before the first frame update
    void Start()
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        // deplacement 
        Vector2 deplacement = speed * Time.deltaTime;
        transform.position += (Vector3)deplacement;         // position vector3 meme en 2D  - casting vector2 en vector3 

        if (speed.x > 0)
        {
            mySpriteRenderer.flipX = false;
        }
        else
        {
            mySpriteRenderer.flipX = true;
        }


    }




}
