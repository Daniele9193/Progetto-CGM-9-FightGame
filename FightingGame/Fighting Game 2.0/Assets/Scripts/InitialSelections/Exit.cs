using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    public void ReturnOnStart()
    {
        SceneManager.LoadScene("Selection");
    }
}
