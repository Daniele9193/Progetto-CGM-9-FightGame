using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variabili : MonoBehaviour
{
    public bool isSkull = false;
    public bool isRing = false;
    public bool isGladiator = false;

    public void SetSkull(string a)
    {
        if (isSkull)
        {
            isSkull = false;
        }
        else
        {
            isSkull = true;
            isGladiator = false;
            isRing = false;
        }
    }
    
    public void SetGladiator(string a)
    {
        if (isGladiator)
        {
            isGladiator = false;
        }
        else
        {
            isSkull = false;
            isGladiator = true;
            isRing = false;
        }
    }
    
    public void SetRing(string a)
    {
        if (isRing)
        {
            isRing = false;
        }
        else
        {
            isSkull = false;
            isGladiator = false;
            isRing = true;
        }
    }
}
