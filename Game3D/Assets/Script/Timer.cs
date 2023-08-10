using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public TMP_Text timerText; // Reference to the TextMeshPro Text element
    public float countdownDuration = 30f; // Countdown duration in seconds
    private float currentTime;

    public GameObject DeathScreen;

    private void Start()
    {
        currentTime = countdownDuration;
        UpdateTimerDisplay();
        StartCountdown();
    }

    private void Update()
    {
        if (currentTime > 0f)
        {
            currentTime -= Time.deltaTime;
            UpdateTimerDisplay();
        }
        else
        {
            currentTime = 0f;
            TimerExpired();
        }
    }

    private void StartCountdown()
    {
        currentTime = countdownDuration;
    }

    private void UpdateTimerDisplay()
    {
        TimeSpan timeSpan = TimeSpan.FromSeconds(currentTime);
        string formattedTime = string.Format("{0:D2}:{1:D2}", timeSpan.Minutes, timeSpan.Seconds);
        timerText.text = formattedTime;
    }

    private void TimerExpired()
    {
        DeathScreen.SetActive(true);
    }
}