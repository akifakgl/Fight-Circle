using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ses : MonoBehaviour
{
    public int callscore;
    public AudioSource kazanma;
    public AudioSource kaybetme;
    // Start is called before the first frame update
    void Start()
    {
        callscore = scoretxt.score;
        if (scoretxt.kontorl == 1)
        {
            kazanma.Play();
            scoretxt.kontorl = 0;
        }
        else
        {
            kaybetme.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
