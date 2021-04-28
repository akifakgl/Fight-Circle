using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class hareketbuyuk : MonoBehaviour
{
    public Button btn;
    public Button btn2;

    public int callscore;
    public int canbuyuk;

    bool bl, b2;
    float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {

        Button btn1 = btn.GetComponent<Button>();
        Button btn3 = btn2.GetComponent<Button>();
    }


    public void pointerDown()
    {
        bl = true;
    }

    public void pointerUp()
    {
        bl = false;
    }
    public void pointerDown2()
    {
        b2 = true;
    }

    public void pointerUp2()
    {
        b2 = false;
    }

    // Update is called once per frame
    private void Update()
    {

        if (bl)
        {
            transform.Rotate(0, 0, speed * 3);
        }

        if (b2)
        {
            transform.Rotate(0, 0, speed * (-3));
        }

    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        callscore = scoretxt.score;
        canbuyuk = scoretxt.canbuyuk;
        canbuyuk++;
        scoretxt.canbuyuk = canbuyuk;
        print("--" + callscore);
        print("++" + canbuyuk);

        if ((callscore - canbuyuk) == (callscore-5) ) 
        {
            scoretxt.canbuyuk = 0;
            scoretxt.score = 0;
            SceneManager.LoadScene(2);

        }

       /* callscore++;
        scoretxt.score = callscore;*/



    }


}
