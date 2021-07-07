using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArenaSelection : MonoBehaviour
{
    public GameObject ArenasCanvas, CharacterList;
    
    public void SelezionaArena(int x)
    {
        PlayerPrefs.SetInt("ArenaSelezionata", x);
        CharacterList.SetActive(true);
        ArenasCanvas.SetActive(false);
    }
}
