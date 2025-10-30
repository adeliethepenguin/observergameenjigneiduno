using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    bool canDrive = true;

    


    void DisableDriving()
    {
        canDrive = false;
    }

    void EnableDriving()
    {
        canDrive = true;
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {

        }
    }


}
