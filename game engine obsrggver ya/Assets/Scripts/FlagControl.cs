using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagControl : MonoBehaviour
{
    public StreetObject[] cars;

    void Update()
    {


        foreach(StreetObject car in cars)
        {
            if (car.crashed == true&&car.IsLoaded)
            {
                car.UnLoad();
            }
            if (car.transform.position.y >= 5.5 && !car.IsLoaded)
            {
                car.Load();
            }
        }


    }
}
