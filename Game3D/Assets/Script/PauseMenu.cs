using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{

    public static bool Paused = false;
    public GameObject PauseMenuCanvas;


    void Start()
    {
        Time.timeScale = 1f;

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true;
            Screen.lockCursor = false;

            if (Paused)
            {

                Play();
            }
            else
            {
                Cursor.visible = false;

                Stop();
            }
        }
    }

    public void Stop()
    {
        PauseMenuCanvas.SetActive(true);
        Time.timeScale = 0f;
        Paused = true;
    }

    public void Play()
    {
        PauseMenuCanvas.SetActive(false);
        Time.timeScale = 1f;
        Paused = false;
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void BackButton()
    {
        Application.Quit();
    }

}
 