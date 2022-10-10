using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainmenu : MonoBehaviour
{
    public void LoadGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }

    public void GoToSettingsMenu()
    {
        SceneManager.LoadScene("settingsMenu");
    }
    public void QuitGame()

    {
        Application.Quit();
    }

}

