using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            LevelsManager.LoseLife();
        }
        else
        {
            Destroy(collision.gameObject);          // comme ca les monstre qui tombe destroy aussi 
        }
    }
}

