using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text countdownText;
    float timeLeft = 3.0f;
    GameObject car;

    private void Start()
    {
        car = GameObject.FindGameObjectWithTag("Car");
    }
    void Update()
    {      
        CountdownTimer();
    }

    void CountdownTimer()
    {
        timeLeft -= Time.deltaTime;
        int textCount = Convert.ToInt32(timeLeft);
        countdownText.text = textCount.ToString();
        if (timeLeft < 0)
        {
            countdownText.text = null;
            car.GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}
