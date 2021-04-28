using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hareketkucuk : MonoBehaviour
{
    public Button btn;
    public Button btn2;

    bool bl, b2;
    float speed = 1f;

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
    void Update()
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
}
