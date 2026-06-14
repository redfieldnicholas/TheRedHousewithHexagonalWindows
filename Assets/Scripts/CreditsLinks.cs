using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsLinks : MonoBehaviour
{
    public void OpenItch()
    {
        Application.OpenURL("https://redfieldnicholas.itch.io/");
    }
    public void PlayPlay()
    {
        SceneManager.LoadScene(1);
    }
    public void ExitExit()
    {
        Application.Quit();
    }
}