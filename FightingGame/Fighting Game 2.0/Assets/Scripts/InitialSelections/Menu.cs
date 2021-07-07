using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{

    
    public GameObject RivalList, CharacterList, ArenasCanvas, StartCanvas, OptionsCanvas, MenuCanvas;

    public void Inizio()
    {
        RivalList.SetActive(true);
        MenuCanvas.SetActive(false);
    }













    // Start is called before the first frame update
    public void RivalScene()
    {
        SceneManager.LoadScene("RivalSelection");
    }
    
    public void OptionScene()
    {
        SceneManager.LoadScene("Options");
    }
    
    public void HomeScene()
    {
        SceneManager.LoadScene("Start");
    }
}
