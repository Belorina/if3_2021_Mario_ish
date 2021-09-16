using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LevelsManager LevelsManager = LevelsManager.instance;
        GameObject player = LevelsManager.player;
        player.transform.position = transform.position;
    }
}
