using UnityEngine;
using UnityEngine.UI;
public class CharacterSelection : MonoBehaviour
{
   private GameObject[] characterList;
    private int index;
    public GameObject audiomanager, nome;
    private AudioManager sounds;
    
    void Start()
    {
        sounds = audiomanager.GetComponent<AudioManager>();
        index = 0;
        characterList = new GameObject[transform.childCount]; //instanziamo una nuova lista di GameObject per creare la lista dei personaggi
                                                              //childCount prende il numero di figli dell'oggetto a cui è associato lo script
        
        for (int i = 0; i < transform.childCount; i++)
            characterList[i] = transform.GetChild(i).gameObject; //riempiamo la lista appena creata con i figli dell'oggetto (i personaggi)

        foreach (GameObject character in characterList)
            character.SetActive(false); //disabilitiamo tutti i personaggi in maniera tale che allo start siano tutti non visibili

        if (characterList[index])
            characterList[index].SetActive(true); //tranne il primo personaggio se c'è (nella scena di selezione)
                                                  //se è stato selezionato un personaggio attiviamo quello.
        
        nome.GetComponent<Text>().text = characterList[index].name;
        PlayerPrefs.SetInt("PersonaggioSelezionato", index);
    }

    public void PersonaggioPrecedente()
    {
        sounds.Play("previous");
        characterList[index].SetActive(false); //disabilitiamo il personaggio attualmente visualizzato
        
        index--;
        if (index < 0)
            index = characterList.Length - 1;
        nome.GetComponent<Text>().text = characterList[index].name;
        characterList[index].SetActive(true); //abilitiamo il personaggio precedente al personaggio visualizzato prima di premere il pulsante
                                              //se il personaggio attuale è il primo visualizziamo l'ultimo personaggio della lista.
        PlayerPrefs.SetInt("PersonaggioSelezionato", index);                                              
    }
    
    public void PersonaggioSuccessivo()
    {
        sounds.Play("next");
        characterList[index].SetActive(false); //disabilitiamo il personaggio attualmente visualizzato
        
        index++;
        if (index == characterList.Length)
            index = 0;
        nome.GetComponent<Text>().text = characterList[index].name;
        characterList[index].SetActive(true); //abilitiamo il personaggio precedente al personaggio visualizzato prima di premere il pulsante
                                              //se il personaggio attuale è l'ultimo visualizziamo il primo personaggio della lista.
        PlayerPrefs.SetInt("PersonaggioSelezionato", index);
    }
}
