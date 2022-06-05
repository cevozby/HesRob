using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    int index;
    [SerializeField] GameObject pauseMenu;
   

    private void Start()
    {
        index = SceneManager.GetActiveScene().buildIndex;
        pauseMenu.SetActive(false);
    }


    public void StartButton()
    {
        SceneManager.LoadScene("FirstMachine");
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(index);
    }

    public void QuitButton()
    {
        Application.Quit();
    }

    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Devam()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Menu()
    {
        SceneManager.LoadScene("GameLevels");
    }

    

}
