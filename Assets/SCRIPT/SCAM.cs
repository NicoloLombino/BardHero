using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCAM : MonoBehaviour
{
    public GameObject censura;
    public int counter;

    public GameObject image;
    public bool imageopen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S) && counter == 0)
        {
            counter = 1;
        }

        else if (Input.GetKeyDown(KeyCode.C) && counter == 1)
        {
            counter = 2;
        }

        else if (Input.GetKeyDown(KeyCode.A) && counter == 2)
        {
            counter = 3;
        }

        else if (Input.GetKeyDown(KeyCode.M) && counter == 3)
        {
            counter = 4;
            image.SetActive(true);
            imageopen = true;
            Destroy(censura);
        }

        else if (Input.GetKeyDown(KeyCode.Q) && imageopen == false)
        {
            counter = 0;
        }

        else if (Input.GetKeyDown(KeyCode.Q) && imageopen == true)
        {
            Destroy(image);
        }
    }
}
