using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{
   private GameObject[] characterList;
    private int index;
    private int arena;
    private int rival;

    void Start()
    {
        index = 0;
        arena = PlayerPrefs.GetInt("ArenaSelezionata");
        rival = PlayerPrefs.GetInt("AvversarioSelezionato");
        characterList = new GameObject[transform.childCount]; //instanziamo una nuova lista di GameObject per creare la lista dei personaggi
                                                              //childCount prende il numero di figli dell'oggetto a cui è associato lo script

        for (int i = 0; i < transform.childCount; i++)
            characterList[i] = transform.GetChild(i).gameObject; //riempiamo la lista appena creata con i figli dell'oggetto (i personaggi)

        foreach (GameObject character in characterList)
            character.SetActive(false); //disabilitiamo tutti i personaggi in maniera tale che allo start siano tutti non visibili

        if (characterList[index])
            characterList[index].SetActive(true); //tranne il primo personaggio se c'è (nella scena di selezione)
                                                  //se è stato selezionato un personaggio attiviamo quello.
    }

    public void PersonaggioPrecedente()
    {
        characterList[index].SetActive(false); //disabilitiamo il personaggio attualmente visualizzato
        
        index--;
        if (index < 0)
            index = characterList.Length - 1;

        characterList[index].SetActive(true); //abilitiamo il personaggio precedente al personaggio visualizzato prima di premere il pulsante
                                              //se il personaggio attuale è il primo visualizziamo l'ultimo personaggio della lista.
    }
    
    public void PersonaggioSuccessivo()
    {
        characterList[index].SetActive(false); //disabilitiamo il personaggio attualmente visualizzato
        
        index++;
        if (index == characterList.Length)
            index = 0;

        characterList[index].SetActive(true); //abilitiamo il personaggio precedente al personaggio visualizzato prima di premere il pulsante
                                              //se il personaggio attuale è l'ultimo visualizziamo il primo personaggio della lista.
    }

    public void PulsanteConferma()
    {
        PlayerPrefs.SetInt("PersonaggioSelezionato", index);
        switch (arena)
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
