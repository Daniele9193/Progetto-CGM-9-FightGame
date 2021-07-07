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
        OptionCanvas.SetActive(false);
        StartCanvas.SetActive(true);
    }

    public void Inizio()
    {
        RivalList.SetActive(true);
        StartCanvas.SetActive(false);
    }
    
}
