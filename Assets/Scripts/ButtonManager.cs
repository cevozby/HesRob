using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    int index;

    private void Start()
    {
        index = SceneManager.GetActiveScene().buildIndex;
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

}
