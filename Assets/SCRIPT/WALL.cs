using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WALL : MonoBehaviour
{
    GameController gc;
    public GameObject gamecontrol;

    public GameObject finallight;

    public GameObject finalimage;

    public float counter;
    public float timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (counter == 3)
        {
            finalimage.SetActive(true);
            timer += Time.deltaTime;
            gamecontrol.GetComponent<GameController>().finishgame = true;
        }

        if (timer >= 2)
        {
            gamecontrol.GetComponent<GameController>().vote.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Disc")
        {
            gamecontrol.GetComponent<GameController>().score -= 1;
            gamecontrol.GetComponent<GameController>().missedscore += 1;
        }

        if (other.gameObject.tag == "LastDisc")
        {
            finallight.SetActive(true);
        }

        if (other.gameObject.tag == "invisibleDisc")
        {
            counter += 1;
        }
    }


}
