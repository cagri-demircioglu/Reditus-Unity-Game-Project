using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public static bool GameIsPause = false;
    public GameObject pauseMenuUI;
	
	void Update ()
    {

	}

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPause = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPause = true;
    }

    public void pauseButton()
    {
        if (GameIsPause)
        {
            Resume();
        }
        else
        {
            Pause();
        }
    }

    public void MenuDon()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("anaMenu");
    }

    public void Mute()
    {
        AudioListener.pause = !AudioListener.pause;
    }
}
