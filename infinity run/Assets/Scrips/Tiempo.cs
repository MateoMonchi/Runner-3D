using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Tiempo : MonoBehaviour
{
    public float time;
    public TextMeshProUGUI timeText;
    public bool timeRunning;
    void Start()
    {
        timeRunning = true; 
    }

   
    void Update()
    {
       
        timeText.text = time.ToString("F2");
        if (timeRunning == true ) {
            time += Time.deltaTime;
        }
    }
}
