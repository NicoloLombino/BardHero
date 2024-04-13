using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySong : MonoBehaviour
{
    public GameObject panelmenu;
    public GameObject gametext;

    public GameObject song1;
    public GameObject song2;
    public GameObject song3;

    public float songcounter;

    public GameObject animationdissolve;

    public GameObject gamecontrol;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow)  && songcounter > 0)
        {
            transform.position = new Vector3(transform.position.x + 350, transform.position.y, transform.position.z);
            songcounter -= 1;
        }

        else if (Input.GetKeyDown(KeyCode.RightArrow) && songcounter < 2)
        {
            transform.position = new Vector3(transform.position.x - 350, transform.position.y, transform.position.z);
            songcounter += 1;
        }

        AlbumChosen();
    }

    void AlbumChosen()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (songcounter == 0)
            {
                song1.SetActive(true);
                panelmenu.SetActive(false);
                gametext.SetActive(false);
                animationdissolve.SetActive(true);

                gamecontrol.GetComponent<GameController>().songstart = song1;
                gamecontrol.GetComponent<GameController>().positionsongstart = new Vector3(song1.transform.position.x, song1.transform.position.y, song1.transform.position.z);
            }

            else if (songcounter == 1)
            {
                song2.SetActive(true);
                panelmenu.SetActive(false);
                gametext.SetActive(false);
                animationdissolve.SetActive(true);

                gamecontrol.GetComponent<GameController>().songstart = song2;
                gamecontrol.GetComponent<GameController>().positionsongstart = new Vector3(song2.transform.position.x, song2.transform.position.y, song2.transform.position.z);
            }

            else if (songcounter == 2)
            {
                song3.SetActive(true);
                panelmenu.SetActive(false);
                gametext.SetActive(false);
                animationdissolve.SetActive(true);

                gamecontrol.GetComponent<GameController>().songstart = song3;
                gamecontrol.GetComponent<GameController>().positionsongstart = new Vector3(song3.transform.position.x, song3.transform.position.y, song3.transform.position.z);
            }
        }
    }
}
