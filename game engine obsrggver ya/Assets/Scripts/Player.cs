using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    bool canDrive = true;


    private void Awake()
    {
        EventCarrier.OnOutOfFuel += DisableDriving;
        EventCarrier.OnOutOfTime += DisableDriving;
    }

    void DisableDriving()
    {
        canDrive = false;
    }

    void EnableDriving()
    {
        canDrive = true;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<StreetObject>())
        {
            StreetObject streetcar = collision.GetComponent<StreetObject>();

        }
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {

        }
    }


}
