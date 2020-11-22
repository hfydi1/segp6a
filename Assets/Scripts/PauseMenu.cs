using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenuUI;

    [SerializeField] private bool isPaused;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }

        if (isPaused)
        {
            activateMenu();
        }

        else
        {
            deactivateMenu();
        }
    }

    void activateMenu()
    {
        Time.timeScale = 0; //stop game
        AudioListener.pause = true;
        pauseMenuUI.SetActive(true);
    }

    public void deactivateMenu()
    {
        Time.timeScale = 1; //resume game
        AudioListener.pause = false;
        pauseMenuUI.SetActive(false);
        isPaused = false;
    }
}
