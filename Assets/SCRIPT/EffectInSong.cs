using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectInSong : MonoBehaviour
{
    public GameObject gc;

    public float scoreneed1;
    public float scoreneed2;
    public float scoreneed3;

    public GameObject effect1;
    public GameObject effect2;
    public GameObject effect3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gc.GetComponent<GameController>().score >= scoreneed1 && effect1 != null)
        {
            effect1.SetActive(true);
        }

        if (gc.GetComponent<GameController>().score >= scoreneed2 && effect2 != null)
        {
            effect2.SetActive(true);
        }

        if (gc.GetComponent<GameController>().score >= scoreneed3 && effect3 != null)
        {
            effect3.SetActive(true);
        }
    }
}
