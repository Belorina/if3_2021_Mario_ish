using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string destination;

    public void LoadNextScene(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(destination);
        }
    }
}