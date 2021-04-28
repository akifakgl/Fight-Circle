using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class yesil : MonoBehaviour
{
    public AudioSource carpma;
    public AudioSource kazanma;
    public AudioSource kaybetme;
    public int callscore;
    public int canbuyuk;
    public int cankucuk;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        callscore = scoretxt.score;
        if (callscore == -3)
        {
            SceneManager.LoadScene(2);
            scoretxt.score = 0;
        }

    }


    public void OnTriggerEnter2D(Collider2D other)
    {


        if (other.tag == "green")
        {
            callscore = scoretxt.score;
            callscore++;
            scoretxt.score = callscore;


            canbuyuk = scoretxt.canbuyuk;
            canbuyuk = 0;
            scoretxt.canbuyuk = canbuyuk;
            carpma.Play();



            Destroy(other.gameObject);
            Debug.Log("+1");

        }
        else
        {
           
            //puan eksilt
            Destroy(other.gameObject);
            Debug.Log("-1");


            cankucuk = scoretxt.cankucuk;
            cankucuk--;
            scoretxt.cankucuk = cankucuk;
            carpma.Play();
            if (cankucuk == 0)
            {
                if (PlayerPrefs.GetInt("highscore") < callscore)
                {
                    scoretxt.kontorl = 1;
                    PlayerPrefs.SetInt("highscore", callscore);
                }
                
                cankucuk = 3;
                scoretxt.cankucuk = cankucuk;
                SceneManager.LoadScene(2);

            }
        }


    }

}
