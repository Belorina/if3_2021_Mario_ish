using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{

    public string itemToPickUp;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag(itemToPickUp))
        {
            Destroy(other.gameObject);
        }

    }
}
