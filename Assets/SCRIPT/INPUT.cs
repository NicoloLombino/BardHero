using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class INPUT : MonoBehaviour
{

    public Animation move2;
    GameController gc;
    public GameObject gamecontrol;
    public KeyCode key;

    public AudioSource sound1;

    public GameObject thisdisc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(key) && thisdisc == null)
        {
            move2.Play();   
        }

        else if (Input.GetKeyDown(key) && thisdisc != null)
        {
            move2.Play();
            gamecontrol.GetComponent<GameController>().score += 1;
            Destroy(thisdisc);
            thisdisc = null;
            sound1.Play();
        }

    }

  /*  private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Disc")
        {
            if (Input.GetKeyDown(key))
            {
                gamecontrol.GetComponent<GameController>().score += 1;
                Destroy(other.gameObject);
                sound1.Play();
             
            }
        }
    }*/

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Disc")
        {
            thisdisc = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Disc")
        {
            thisdisc = null;
        }
    }
}
