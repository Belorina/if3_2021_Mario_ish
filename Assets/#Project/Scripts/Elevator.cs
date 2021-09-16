using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    private Transform oldParent;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            oldParent = collision.transform.parent;         // sauvegarder l ancien parent du player
            collision.transform.parent = transform;         // si collision, platform deviens parent  
        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            print("test");
            collision.transform.parent = null;
            DontDestroyOnLoad(LevelsManager.instance.player);
        }
    }
}
