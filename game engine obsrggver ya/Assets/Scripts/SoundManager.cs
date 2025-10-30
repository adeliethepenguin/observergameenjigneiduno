using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SoundManager : MonoBehaviour
{
    public AudioSource crashSound;
    public AudioSource gameOverSound;
    public AudioSource fuelGainSound;

    void PlayCrashSound()
    {
        Debug.Log("crashed!");
        if (crashSound != null)
        {
            crashSound.Play();
        }
    }

    void PlayGameOverSound()
    {
        Debug.Log("game over!");
        if (gameOverSound != null)
        {
            gameOverSound.Play();
        }
        }

        void PlayFuelGainSound(int blargh)
    {
        Debug.Log("You gained " + blargh + " fuel!");
        if (fuelGainSound != null)
        {
            
            fuelGainSound.Play();
        }
    }
    

    void Awake()
    {
        EventCarrier.OnCrashed += PlayCrashSound;
        EventCarrier.OnOutOfTime += PlayGameOverSound;
        EventCarrier.OnOutOfFuel += PlayGameOverSound;
        EventCarrier.OnFuelGet += PlayFuelGainSound;
    }

    void OnDestroy()
    {

    }
}
