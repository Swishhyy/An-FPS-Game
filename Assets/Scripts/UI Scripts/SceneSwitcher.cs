using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void GotoMenuScene()
    {
    SceneManager.LoadScene("MainMenu");
    }
    public void GotoDemoScene()
    {
    SceneManager.LoadScene("DemoScene");
    }
    public void GotoSettingsScene()
    {
    SceneManager.LoadScene("SettingsScene");
    }
    public void doExitGame() 
    {
        Application.Quit();
    }

}