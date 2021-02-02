using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public float timeRemaining = 10;
    public bool timerIsRunning = false;
    public Text timeText;
    
    public GameObject instructions;
    public GameObject enigme1;
    public GameObject informationsButton1;
    public GameObject enigme2;
    public GameObject informationsButton2;
    public GameObject enigme3;
    public GameObject informationsButton3;
    public GameObject textInputField;
    public GameObject validateButton;
    public GameObject textInputField2;
    public GameObject validateButton2;
    public GameObject textInputField3;
    public GameObject validateButton3;
    public GameObject recorder;
    public GameObject timer;
    public GameObject defaite;
    public GameObject help;
    public GameObject restart;

    private void Start()
    {
        // Starts the timer automatically
        timerIsRunning = true;
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            
            else
            {
                timeRemaining = 0;
                timerIsRunning = false;
                
                instructions.SetActive(false);
                enigme1.SetActive(false);
                informationsButton1.SetActive(false);
                enigme2.SetActive(false);
                informationsButton2.SetActive(false);
                enigme3.SetActive(false);
                informationsButton3.SetActive(false);
                textInputField.SetActive(false);
                validateButton.SetActive(false);
                textInputField2.SetActive(false);
                validateButton2.SetActive(false);
                textInputField3.SetActive(false);
                validateButton3.SetActive(false);
                timer.SetActive(false);
                recorder.SetActive(false);
                defaite.SetActive(true);
                help.SetActive(false);
                restart.SetActive(true);
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60); 
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}