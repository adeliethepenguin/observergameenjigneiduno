using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StreetObject : MonoBehaviour
{
    public float speed;
    public bool fuel;
    public SpriteRenderer sprite;

    void Start()
    {
        if (sprite == null)
        {
            sprite = this.GetComponent<SpriteRenderer>();
        }    }

    void Update()
    {
        if (transform.position.y <= -0.4f)
        {
            transform.position = new Vector3(Random.Range(-0.45f, 0.45f), 0.35f, transform.position.z);
            if (Random.Range(0, 9) > 8)
            {
                fuel = true;
                sprite.color = Color.green;
            }
            else
            {
                fuel = false;
                sprite.color = Color.black;
            }
        } 
    }

    void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y - speed, transform.position.z);
        
    }

}
