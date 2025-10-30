using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class EventCarrier : MonoBehaviour
{
    public static Action OnCrashed;
    public static Action OnOutOfFuel;
    public static Action OnOutOfTime;
    public static Action<int> OnFuelGet;
    public static Action GameRestart;

    public void Crashed(){ OnCrashed?.Invoke(); }
    public void OutOfFuel(){ OnOutOfFuel?.Invoke(); }
    public void OutOfTime(){ OnOutOfTime?.Invoke(); }
    public void FuelGet(int amount){ OnFuelGet?.Invoke(amount); }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
