using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelsManager : MonoBehaviour
{
    public static LevelsManager instance = null;               // variable pour ce stocker sois meme / variable static = qui est le emme a chaque fois 

    public GameObject playerPrefab;
    public GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            DontDestroyOnLoad(gameObject);              // le gameObject (avec petit g) sur le quelle est ce script / dontdestroyonload = le empty sur le quelle il est ne ce detruit pas en changement de scene
            instance = this;                            // this = moi (le script) 

            player = Instantiate(playerPrefab);         // instantiate pure (0, 0 che pas quoi)
            DontDestroyOnLoad(player);                  //object roboboy ne va pas etre destruit on load non plus  
        }
        else
        {
            Destroy(gameObject);                        // je destroy moi memem car je suis pas le premier (y a deja un meme dans la scene) 
        }                                               // 
    }

    // Update is called once per frame
    void Update()
    {

    }
}
