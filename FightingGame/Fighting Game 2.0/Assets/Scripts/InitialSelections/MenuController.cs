using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject RivalList, CharacterList, ArenasCanvas, StartCanvas, OptionsCanvas, audioManager;
    private AudioManager sounds;
    void Start()
    {
        sounds = audioManager.GetComponent<AudioManager>();
        RivalList.SetActive(false);
        CharacterList.SetActive(false);
        ArenasCanvas.SetActive(false);
        OptionsCanvas.SetActive(false);
        StartCanvas.SetActive(true);
    }

    public void Starting()
    {
        sounds.Play("confirm");
        StartCanvas.SetActive(false);
        RivalList.SetActive(true);
    }

    public void Options()
    {
        sounds.Play("confirm");
        StartCanvas.SetActive(false);
        OptionsCanvas.SetActive(true);
    }

    public void StartFromOptions()
    {
        sounds.Play("confirm");
        OptionsCanvas.SetActive(false);
        StartCanvas.SetActive(true);
    }
    
    public void PulsanteConfermaRivale()
    {
        sounds.Play("confirm");
        ArenasCanvas.SetActive(true);
        RivalList.SetActive(false);
    }
    
    public void SelezionaArena(int x)
    {
        sounds.Play("confirm");
        PlayerPrefs.SetInt("ArenaSelezionata", x);
        CharacterList.SetActive(true);
        ArenasCanvas.SetActive(false);
    }

    public void PlayGame()
    {
        sounds.Play("confirm");
        switch (PlayerPrefs.GetInt("ArenaSelezionata"))
                {
                    case 0:
                        SceneManager.LoadScene("TrainingArena");
                        break;
                    case 1:
                        SceneManager.LoadScene("SkullArena");
                        break;
                    case 2:
                        SceneManager.LoadScene("BoxArena");
                        break;
                    case 3:
                        SceneManager.LoadScene("RomanArena");
                        break;
                    case 4:
                        SceneManager.LoadScene("HouseArena");
                        break;
                    case 5:
                        SceneManager.LoadScene("RuinsArena");
                        break;
                    case 6:
                        SceneManager.LoadScene("VillageArena");
                        break;
                    case 7:
                        SceneManager.LoadScene("CityArena");
                        break;
                    case 8:
                        SceneManager.LoadScene("SkyArena");
                        break;
                    case 9:
                        SceneManager.LoadScene("HospitalArena");
                        break;
                    case 10:
                        SceneManager.LoadScene("TempleArena");
                        break;
                    case 11:
                        SceneManager.LoadScene("VolcanoArena");
                        break;
                }
    }
}