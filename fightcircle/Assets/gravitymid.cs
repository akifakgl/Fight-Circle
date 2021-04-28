using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravitymid : MonoBehaviour
{
    public GameObject planet;

    public float maxg;
    public float maxgd;

    public int level;
    public int leveldegiskeni = 10;

    public Rigidbody2D rb;
    // Use this for initialization
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {
        level = scoretxt.score;


        if (level == leveldegiskeni)
        {
            print("****************************************"+level);
            leveldegiskeni = leveldegiskeni + (int)(leveldegiskeni * 0.9f);
            maxg = maxg * 1.15f;
            print("******" + maxg);
            
        }

        float dist = Vector2.Distance(planet.transform.position, transform.position);

        Vector2 v = planet.transform.position + transform.position;
        rb.AddForce(v.normalized * (2f - dist / maxgd) * maxg);




    }
}
