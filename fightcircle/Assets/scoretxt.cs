using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoretxt : MonoBehaviour
{


    public Text txt;
    public static int score=0;
    public static int kontorl = 0;
    public static int canbuyuk=0;
    public static int cankucuk = 3;
    // Start is called before the first frame update
    void Start()
    {
        txt.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = score.ToString();
       
    }
    
}
