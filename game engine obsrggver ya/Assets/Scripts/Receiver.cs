using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Receiver : MonoBehaviour
{
    public Stack<int> positions;

    private void Start()
    {
        positions.Push(0);
    }


    public void PushVert(int newPos)
    {
        positions.Push(newPos);
    }
    
    public void PopLastVert()
    {
        positions.Pop();
    }

    public int LastVert()
    {
        return positions.Peek();
    }
}
