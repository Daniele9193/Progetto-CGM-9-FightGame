using UnityEngine;
using UnityEngine.UI;

public class RivalSelection : MonoBehaviour
{
    private GameObject[] rivalList;
    private int index;
    public GameObject audiomanager, nome;
    private AudioManager sounds;

    void Start()
    {
        sounds = audiomanager.GetComponent<AudioManager>();
        index = 0;
        rivalList = new GameObject[transform.childCount]; //instanziamo una nuova lista di GameObject per creare la lista dei personaggi
                                                              //childCount prende il numero di figli dell'oggetto a cui è associato lo script
        
        for (int i = 0; i < transform.childCount; i++)
            rivalList[i] = transform.GetChild(i).gameObject; //riempiamo la lista appena creata con i figli dell'oggetto (i personaggi)

        foreach (GameObject character in rivalList)
            character.SetActive(false); //disabilitiamo tutti i personaggi in maniera tale che allo start siano tutti non visibili

        if (rivalList[index])
            rivalList[index].SetActive(true); //tranne il primo personaggio se c'è (nella scena di selezione)
                                              //se è stato selezionato un personaggio attiviamo quello.
        
        nome.GetComponent<Text>().text = rivalList[index].name;
        PlayerPrefs.SetInt("AvversarioSelezionato", index);
    }

    public void PersonaggioPrecedente()
    {
        sounds.Play("previous");
        rivalList[index].SetActive(false); //disabilitiamo il personaggio attualmente visualizzato
        
        index--;
        if (index < 0)
            index = rivalList.Length - 1;
        nome.GetComponent<Text>().text = rivalList[index].name;
        rivalList[index].SetActive(true); //abilitiamo il personaggio precedente al personaggio visualizzato prima di premere il pulsante
                                          //se il personaggio attuale è il primo visualizziamo l'ultimo personaggio della lista.
        PlayerPrefs.SetInt("AvversarioSelezionato", index);
    }
    
    public void PersonaggioSuccessivo()
    {
        sounds.Play("next");
        rivalList[index].SetActive(false); //disabilitiamo il personaggio attualmente visualizzato
        
        index++;
        if (index == rivalList.Length)
            index = 0;
        nome.GetComponent<Text>().text = rivalList[index].name;
        rivalList[index].SetActive(true); //abilitiamo il personaggio precedente al personaggio visualizzato prima di premere il pulsante
                                          //se il personaggio attuale è l'ultimo visualizziamo il primo personaggio della lista.
        PlayerPrefs.SetInt("AvversarioSelezionato", index);
    }
}
