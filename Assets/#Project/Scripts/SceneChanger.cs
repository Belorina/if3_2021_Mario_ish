using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Change();
        }
    }
   public void Change()                       //(string sceneName)
    {
        
        SceneManager.LoadScene("SecondScene");

    }
    
    public void Exit()
    {
        Application.Quit();
    }
}
