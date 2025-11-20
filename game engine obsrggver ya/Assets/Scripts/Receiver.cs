using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Receiver : MonoBehaviour
{
    public Stack<int> positions = new Stack<int>();

    private void Awake()
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
        if (positions.Count == 0)
        {
            positions.Push(0);
        }
        return positions.Peek();
    }
}
