using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ArenaSelection : MonoBehaviour
{
    public void SelezionaArena(int x)
    {
        PlayerPrefs.SetInt("ArenaSelezionata", x);
        SceneManager.LoadScene("CharacterSelection");
    }
}
