using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishPanel : MonoBehaviour
{
    public GameObject gamecontrol;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //gamecontrol.GetComponent<GameController>().returntomenu();
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}
