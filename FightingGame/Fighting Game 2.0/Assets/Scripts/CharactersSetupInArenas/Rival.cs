using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rival : MonoBehaviour
{
    private int index;

    private GameObject[] rivalList;

    void Start()
    {
        index = PlayerPrefs.GetInt("AvversarioSelezionato");
        rivalList = new GameObject[transform.childCount]; //instanziamo una nuova lista di GameObject per creare la lista dei personaggi
                                                          //childCount prende il numero di figli dell'oggetto a cui è associato lo script

        for (int i = 0; i < transform.childCount; i++)
            rivalList[i] = transform.GetChild(i).gameObject; //riempiamo la lista appena creata con i figli dell'oggetto (i personaggi)

        foreach (GameObject character in rivalList)
            character.SetActive(false);                 //disabilitiamo tutti i personaggi in maniera tale che allo start siano tutti non visibili

        if (rivalList[index])
            rivalList[index].SetActive(true); //tranne il primo personaggio se c'è (nella scena di selezione)
                                              //se è stato selezionato un personaggio attiviamo quello.
    }
}
