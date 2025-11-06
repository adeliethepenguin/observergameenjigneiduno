using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    bool canDrive = true;
    public EventCarrier events;
    int fuel = 100;
    public int fuelGainAmount;
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

            streetcar.crashed = true;
            if (streetcar.fuel)
            {
                events.FuelGet(fuelGainAmount);
            }

        }
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y, transform.position.z);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y, transform.position.z);
        }
    }


}
