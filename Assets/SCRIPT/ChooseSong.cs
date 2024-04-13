using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseSong : MonoBehaviour
{
    public float counter;
    public bool AlbumOpen = false;
    public GameObject album1;
    public GameObject album2;
    public GameObject album3;

    public bool menuclosed;
    public GameObject menu;
    public GameObject gamecontrol;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (menuclosed == true)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow) && AlbumOpen == false && transform.position.x < 3500)
            {
                transform.position = new Vector3(transform.position.x + 350, transform.position.y, transform.position.z);
                counter -= 1;
            }

            else if (Input.GetKeyDown(KeyCode.RightArrow) && AlbumOpen == false && transform.position.x > -3500)
            {
                transform.position = new Vector3(transform.position.x - 350, transform.position.y, transform.position.z);
                counter += 1;
            }

            if (Input.GetKeyDown(KeyCode.Q))
            {
                menu.SetActive(true);
                menuclosed = false;
            }

            AlbumChosen();
            CloseAlbum();
        }
    }

    void AlbumChosen()
    {
        if (Input.GetKeyDown(KeyCode.E) && AlbumOpen == false)
        {
            if (counter == 0)
            {
                album1.SetActive(true);
                AlbumOpen = true;
                gamecontrol.GetComponent<GameController>().albumstart = album1;
            }

            else if (counter == 1)
            {
                album2.SetActive(true);
                AlbumOpen = true;
                gamecontrol.GetComponent<GameController>().albumstart = album2;
            }

            else if (counter == 2)
            {
                album3.SetActive(true);
                AlbumOpen = true;
                gamecontrol.GetComponent<GameController>().albumstart = album3;
            }
        }
    }

    void CloseAlbum()
    {
        if (Input.GetKeyDown(KeyCode.Q) && AlbumOpen == true)
        {
            album1.SetActive(false);
            album2.SetActive(false);
            album3.SetActive(false);
            AlbumOpen = false;
        }

    }

    public void closemenu()
    {
        menuclosed = true;
    }
 
}
