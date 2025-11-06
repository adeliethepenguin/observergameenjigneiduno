using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sector : MonoBehaviour
{
    public bool IsLoaded { get; private set; } = false;
    public bool IsDirty { get; private set; } = false;

    void Awake()
    {
        Clean();
        IsLoaded = true ;
    }

    public void MarkDirty()
    {
        IsDirty = true;
    }

    public void Load()
    {
        
        IsLoaded = true;
        this.GetComponent<Collider2D>().enabled=true;
        if (this.GetComponent<StreetObject>())
        {
            this.GetComponent<StreetObject>().crashed = false;
            if (this.GetComponent<StreetObject>().fuel)
            {
                this.GetComponent<SpriteRenderer>().color = Color.green;
            }
            else
            {
                this.GetComponent<SpriteRenderer>().color = Color.red;
            }
        }
        
    }
    public void UnLoad()
    {
        IsLoaded = false;
        this.GetComponent<Collider2D>().enabled = false;
        this.GetComponent<SpriteRenderer>().color = Color.grey;

    }


    public void Clean()
    {
        IsDirty = false;
    }
}
