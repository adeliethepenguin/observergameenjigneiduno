using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIControl : MonoBehaviour
{
    public Image gameOverScreen;
    public TMP_Text timerText;
    public TMP_Text fuelText;
    float timer = 0;
    public float maxTime;

    void ShowGameOverScreen()
    {
        gameOverScreen.gameObject.SetActive(true);
    }
    void Update()
    {
        timer += Time.deltaTime;
        UpdateTimer();
    }

    void UpdateTimer()
    {
        timerText.text = "Time left: "+(maxTime-timer);
    }
}
