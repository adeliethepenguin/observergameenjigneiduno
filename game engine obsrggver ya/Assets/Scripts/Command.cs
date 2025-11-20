using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Command : MonoBehaviour
{
    public Receiver rec;

    public int[] positions;


    public void GoUp(Transform trans)
    {
        
        if (rec.LastVert()==positions[0])
        {
            trans.position = new Vector3(trans.position.x, positions[1], trans.position.z);
            rec.PushVert(positions[1]);
        }
        else if (rec.LastVert() == positions[1])
        {
            trans.position = new Vector3(trans.position.x, positions[2], trans.position.z);
            rec.PushVert(positions[2]);
        }
        else
        {
            trans.position = new Vector3(trans.position.x, positions[0], trans.position.z);
            rec.PushVert(positions[0]);
        }
    }

    public void GoDown(Transform trans)
    {
        if (rec.LastVert() == positions[0])
        {
            trans.position = new Vector3(trans.position.x, positions[2], trans.position.z);
            rec.PushVert(positions[2]);
        }
        else if (rec.LastVert() == positions[1])
        {
            trans.position = new Vector3(trans.position.x, positions[0], trans.position.z);
            rec.PushVert(positions[0]);
        }
        else
        {
            trans.position = new Vector3(trans.position.x, positions[1], trans.position.z);
            rec.PushVert(positions[1]);
        }
    }

    public void Undo(Transform trans)
    {
        trans.position = new Vector3(trans.position.x, rec.LastVert(), trans.position.z);

        rec.PopLastVert();
    }

}
