using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    public bool isSkull = false;
    public bool isRing = false;
    public bool isGladiator = false;
    
    public void Inizio()
    {
        if (isSkull)
        {
            SceneManager.LoadScene("Skull Arena");
        }
        else if (isGladiator)
        {
            SceneManager.LoadScene("Gladiator Arena");
        }
        else if (isRing)
        {
            SceneManager.LoadScene("Battle Arena");
        }
    }

    public void Skull()
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
    
    public void Gladiator()
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
    
    public void Ring()
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
