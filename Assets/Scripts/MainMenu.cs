using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void LoadComputerGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void LoadPlayerGame()
    {
        SceneManager.LoadScene("VersusScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
