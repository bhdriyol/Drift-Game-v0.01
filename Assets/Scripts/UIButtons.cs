using UnityEngine;
using UnityEngine.SceneManagement;

public class UIButtons : MonoBehaviour
{
    public void MainMenuScene()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void BeforeScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void OptionsMenu()
    {
        SceneManager.LoadScene("Options");
    }
}
