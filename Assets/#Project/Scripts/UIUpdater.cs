using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIUpdater : MonoBehaviour
{
    public static UIUpdater instance = null;
    public Image[] lifeImages;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        instance = this;

    }

    // Update is called once per frame
    void Update()
    {
        for (int index = 0; index < lifeImages.Length; index++)
        {
            lifeImages[index].enabled = index < LevelsManager.lifes;                    // enabled = pour qu il soi svisible 
        }

        if (SceneManager.GetActiveScene().name == "GameOverScene" || SceneManager.GetActiveScene().name == "StartScene")
        {
            Destroy(gameObject);
        }

    }
}
