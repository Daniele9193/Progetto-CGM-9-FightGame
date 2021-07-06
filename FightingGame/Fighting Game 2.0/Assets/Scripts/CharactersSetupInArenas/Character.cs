using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Character : MonoBehaviour
{
    private GameObject[] characterList;
    private int index;
    private int arena;
    private int rival;

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
}