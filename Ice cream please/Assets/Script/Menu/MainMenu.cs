using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string levelToLoad;
    public GameObject howto;

    public void StartGame()
    {
        SceneManager.LoadScene(levelToLoad);

    }

     public void QuitGame()
    {
        Application.Quit();
    }

    public void HowTo()
    {
        howto.SetActive(true);
    }

    public void QuitHowTo()
    {
        howto.SetActive(false);
    }

}
