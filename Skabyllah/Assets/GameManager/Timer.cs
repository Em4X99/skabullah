using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    //Variables
    public TextMeshProUGUI timer;
    private float timernum = 0;
    // Start is called before the first frame update
    void Start()
    {
        timernum = 0;
    }

    // Update is called once per frame
    void Update()
    {
       // make a f timer
       timernum += Time.deltaTime;

        //make the timer show up in the ui
        timer.text = "" + (int)(10 - timernum);

        //make it so that after 10 seconds timer stops
        if (timernum < 10)
        {


        }
        else
        {
           
            timer.text = "OUT OF TIME BITCH";
        }
    }
}
