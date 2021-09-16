using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]             // il mets des composant directement ! 
[RequireComponent(typeof(BoxCollider2D))]       // presiser BOX Collider2D, sinon collider est un truc generique ca n aurais pas marche 

public class Monster : MonoBehaviour
{
    //Collider2D monsterHitBox;

    // Start is called before the first frame update
    void Start()
    {
        //monsterHitBox = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            LevelsManager.LoseLife();
        }
    }
}
