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
    public Player player;

    void ShowGameOverScreen()
    {
        gameOverScreen.gameObject.SetActive(true);
    }
    void Update()
    {
        timer += Time.deltaTime;
        UpdateTimer();
    }
    void UpdateFuel()
    {
        fuelText.text = "Fuel Amount: " + player.fuel;
    }
    void UpdateTimer()
    {
        timerText.text = "Time left: "+(maxTime-timer);
    }
}
