using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject RivalList, CharacterList, ArenasCanvas, StartCanvas, OptionsCanvas;
    
    void Start()
    {
        RivalList.SetActive(false);
        CharacterList.SetActive(false);
        ArenasCanvas.SetActive(false);
        OptionsCanvas.SetActive(false);
        StartCanvas.SetActive(true);
    }

    public void Inizio()
    {
        RivalList.SetActive(true);
        StartCanvas.SetActive(false);
    }

    public void Opzioni()
    {
        OptionsCanvas.SetActive(true);
        StartCanvas.SetActive(false);
    }
    
    public void InizioOpzioni()
    {
        StartCanvas.SetActive(true);
        OptionsCanvas.SetActive(false);
        
    }
}
