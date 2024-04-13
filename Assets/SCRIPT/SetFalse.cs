using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetFalse : MonoBehaviour
{
    public GameObject censura;
    public float timer;
    public AudioSource didntstart;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= 3)
        {
            didntstart.volume = 1;

        }
        else if (timer >= 4)
        {
            didntstart.volume = 1;
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "WALL")
        {
            censura.SetActive(true);
            didntstart.volume = 0.001f;
            timer += Time.deltaTime;
        }
    }
}
