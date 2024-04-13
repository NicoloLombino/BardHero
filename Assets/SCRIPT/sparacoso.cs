using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sparacoso : MonoBehaviour
{
    public GameObject coso;
    public KeyCode key;
    public GameObject buco;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(key))
        {
            Instantiate(coso, buco.transform.position, buco.transform.rotation);
        }
    }
}
