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
        crashSound.Play();
    }

    void PlayGameOverSound()
    {
        gameOverSound.Play();
    }

    void PlayFuelGainSound(int blargh)
    {
        Debug.Log("You gained " + blargh + " fuel!");
        fuelGainSound.Play();
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
