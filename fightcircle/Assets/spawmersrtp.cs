using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawmersrtp : MonoBehaviour
{
    public Transform[] spawnPoint;
    public GameObject[] enemyPrefabs;



    public float spawnTime = 10f;
    //The amount of time between each spawn.
    public float spawnDelay = 0.1f;



    public float gelissayisi=3;
    public int level;
    public int leveldegiskeni=10;
    public float katsayi=0.9f;
    public float gelissayisikatsayi = 0.9f;
    void Start()
    {

        gelissayisi = 2;
        InvokeRepeating("Spawn", 3f, gelissayisi);

        level = scoretxt.score;


    }

    // Update is called once per frame
    void Update()
    {
        
        level = scoretxt.score;

        
        if (level == leveldegiskeni)
        {

            print("****************************************");
            CancelInvoke("Spawn");
            leveldegiskeni = leveldegiskeni+(int)(leveldegiskeni * katsayi);
            gelissayisi = gelissayisi * gelissayisikatsayi;
            if (gelissayisikatsayi > 0.02f)
            {
                gelissayisikatsayi = gelissayisikatsayi - 0.02f;

            }
            print("******" + gelissayisi);
            print("-------"+ leveldegiskeni);
            InvokeRepeating("Spawn", 2f, gelissayisi);
        }
       
    }



    void Spawn()
    {

        int ranEnemy = Random.Range(0, enemyPrefabs.Length);
        int randSpawnPoint = Random.Range(0, spawnPoint.Length);
        Instantiate(enemyPrefabs[ranEnemy], spawnPoint[randSpawnPoint].position, transform.rotation);

    }
}
