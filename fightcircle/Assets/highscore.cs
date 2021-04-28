using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class highscore : MonoBehaviour
{
    public Text HStext;
    // Start is called before the first frame update
    void Start()
    {
        HStext.text = "H I G H S C O R E = " + PlayerPrefs.GetInt("highscore");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
