using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect : MonoBehaviour
{
    public GameObject gamecontrol;

    // Start is called before the first frame update
    void Start()
    {
        if (gamecontrol.GetComponent<GameController>().effectopen1 == null)
        {
            gamecontrol.GetComponent<GameController>().effectopen1 = gameObject;
        }

        else if (gamecontrol.GetComponent<GameController>().effectopen1 != null && gamecontrol.GetComponent<GameController>().effectopen2 == null)
        {
            gamecontrol.GetComponent<GameController>().effectopen2 = gameObject;
        }

        else if (gamecontrol.GetComponent<GameController>().effectopen1 != null  && gamecontrol.GetComponent<GameController>().effectopen2 != null && gamecontrol.GetComponent<GameController>().effectopen3 == null)
        {
            gamecontrol.GetComponent<GameController>().effectopen3 = gameObject;
        }

        else if (gamecontrol.GetComponent<GameController>().effectopen1 != null && gamecontrol.GetComponent<GameController>().effectopen2 != null && gamecontrol.GetComponent<GameController>().effectopen3 != null && gamecontrol.GetComponent<GameController>().effectopen4 == null)
        {
            gamecontrol.GetComponent<GameController>().effectopen4 = gameObject;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
