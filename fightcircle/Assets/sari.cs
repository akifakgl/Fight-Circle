using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class sari : MonoBehaviour
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
      

    }

    public void OnTriggerEnter2D(Collider2D other)
    {


        if (other.tag == "sari")
        {
            callscore = scoretxt.score;
            callscore++;
            scoretxt.score = callscore;
            carpma.Play();

            canbuyuk = scoretxt.canbuyuk;
            canbuyuk = 0;
            scoretxt.canbuyuk = canbuyuk;
            Destroy(other.gameObject);
            Debug.Log("+1");

        }
        else
        {
       
            //puan eksilt
            Destroy(other.gameObject);
            Debug.Log("-1");

            cankucuk=scoretxt.cankucuk;
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
