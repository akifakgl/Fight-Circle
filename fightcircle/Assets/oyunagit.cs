using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class oyunagit : MonoBehaviour
{
    public int callscore;
    public int canbuyuk;
    public int cankucuk;

    public void sahnedegis (string degis)
    {
        cankucuk = 3;
        scoretxt.cankucuk = cankucuk;
        canbuyuk = 0;
        scoretxt.canbuyuk = canbuyuk;
        callscore = 0;
        scoretxt.score = callscore;
        Application.LoadLevel(degis);
    }
}
