using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    bool canDrive = true;
    public EventCarrier events;
    public int fuel = 100;
    public int fuelGainAmount;
    int counter = 0;

    public Command com;
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
        Debug.Log("trigger");
            StreetObject streetcar = collision.GetComponent<StreetObject>();

            streetcar.crashed = true;
        if (streetcar.fuel)
        {
            events.FuelGet(fuelGainAmount);
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

        if (Input.GetKeyDown(KeyCode.I))
        {
            com.GoUp(transform);
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            com.GoDown(transform);
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            com.Undo(transform);
        }

    }

    private void FixedUpdate()
    {
        
        if (counter > 120)
        {
            fuel -= 1;
            counter = 0;
        }
        

        counter += 1;
    }


}
