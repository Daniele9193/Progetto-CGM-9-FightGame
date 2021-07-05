using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{
    private GameObject[] characterList;
    private int index;
    private int arena;

    void Start()
    {
        index = PlayerPrefs.GetInt("PersonaggioSelezionato");
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

    public void SelezionaArena(int x)
    {
        arena = x;
    }

    public void PulsanteConferma()
    {
        PlayerPrefs.SetInt("PersonaggioSelezionato", index);
        switch (arena)
        {
            case 0:
                SceneManager.LoadScene("Training Arena");
                break;
            case 1:
                SceneManager.LoadScene("Skull Arena");
                break;
            case 2:
                SceneManager.LoadScene("Box Arena");
                break;
            case 3:
                SceneManager.LoadScene("Forest Arena");
                break;
            case 4:
                SceneManager.LoadScene("Village Arena");
                break;
            case 5:
                SceneManager.LoadScene("Ruins Arena");
                break;
            case 6:
                SceneManager.LoadScene("House Arena");
                break;
            case 7:
                SceneManager.LoadScene("City Arena");
                break;
            case 8:
                SceneManager.LoadScene("Sky Arena");
                break;
        }
    }
}