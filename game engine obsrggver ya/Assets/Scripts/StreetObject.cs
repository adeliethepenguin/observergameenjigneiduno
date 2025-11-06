using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StreetObject : Sector
{
    public float speed;
    public bool fuel;
    public bool crashed = false;
    public SpriteRenderer sprite;

    void Start()
    {
        if (sprite == null)
        {
            sprite = this.GetComponent<SpriteRenderer>();
        }    }

    void Update()
    {
        if (this.transform.position.y <= -4)
        {
            this.transform.position = new Vector3(Random.Range(-4.5f, 4.5f), 6.5f, transform.position.z);
            if (Random.Range(0, 9) > 8)
            {
                fuel = true;
                sprite.color = Color.black;
            }
            else
            {
                fuel = false;
                sprite.color = Color.green;
            }
        }
        else
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - speed * Time.deltaTime, transform.position.z);
        }
    }

    void FixedUpdate()
    {
       
        
    }

}
