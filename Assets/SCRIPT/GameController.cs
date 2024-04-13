using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameController : MonoBehaviour
{
    public int score;
    public Text scoretext;
    public Text scoretext2;

    public int missedscore;
    public Text missedscoretext;

    public bool finishgame;
    public GameObject vote;
    public GameObject votefeniano;
    public GameObject votekern;
    public GameObject voterecluta;
    public GameObject votenovizio;
    public GameObject votemarry;

    public float timer;

    //COSE PER IL RESTART
    public GameObject effectopen1;
    public GameObject effectopen2;
    public GameObject effectopen3;
    public GameObject effectopen4;

    public GameObject songstart;
    public Vector3 positionsongstart;

    public GameObject panelmenu;
    public GameObject panelsongs;
    public GameObject panelfinal;
    public GameObject wall;
    public GameObject albumstart;
    public GameObject invisiblediscs;
    public GameObject finalblock;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = score.ToString();
        scoretext2.text = score.ToString();
        missedscoretext.text = missedscore.ToString();

        if (finishgame == true)
        {
            rating();
        }

        exitgame();


    }

    void exitgame()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    void rating()
    {
        timer += Time.deltaTime;
        if (timer >= 5)
        {
            if (score / (missedscore + 1) >= score  && score >= 0)
            {
                votemarry.SetActive(true);
            }

            else if (score / (missedscore + 1) >= 17 && score / (missedscore + 1) < (score + 100) / 2  && score >= 0)
            {
                votefeniano.SetActive(true);
            }

            else if (score / (missedscore + 1) >= 7.74f && score / (missedscore + 1) < 17  && score >= 0)
            {
                votekern.SetActive(true);
            }

            else if (score / (missedscore + 1) >= 1.48f && score / (missedscore + 1) < 7.74f  && score >= 0)
            {
                voterecluta.SetActive(true);
            }

            else if (score / (missedscore + 1) < 1.48f)
            {
                votenovizio.SetActive(true);
            }
        }
    }

    public void returntomenu()
    {
        score = 0;
        missedscore = 0;
        effectopen1.SetActive(false);
        effectopen2.SetActive(false);
        effectopen3.SetActive(false);
        //effectopen4.SetActive(false);

        effectopen1 = null;
        effectopen2 = null;
        effectopen3 = null;
        //effectopen4 = null;

        songstart.transform.position = positionsongstart;
        songstart.SetActive(false);

        panelfinal.SetActive(false);
        panelmenu.SetActive(true);
        panelsongs.SetActive(true);

        score = 0;
        missedscore = 0;
        finishgame = false;
        timer = 0;
        wall.GetComponent<WALL>().counter = 0;
        wall.GetComponent<WALL>().timer = 0;
        wall.GetComponent<WALL>().finallight.transform.position = new Vector3(0, 0, 0);
        wall.GetComponent<WALL>().finallight.SetActive(false);
        albumstart.SetActive(false);
        panelsongs.GetComponentInChildren<ChooseSong>().AlbumOpen = false;
        panelsongs.GetComponentInChildren<ChooseSong>().menuclosed = false;

        /*vote.SetActive(false);
        votefeniano.SetActive(false);
        votekern.SetActive(false);
        voterecluta.SetActive(false);
        votenovizio.SetActive(false);
        votemarry.SetActive(false);  */
        invisiblediscs.transform.position = new Vector3(0, 0, 0);
        finalblock.SetActive(false);
    }

}
