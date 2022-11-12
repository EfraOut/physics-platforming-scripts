using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This class holds what it needs to have a simple pause menu.
public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!pauseMenu.activeSelf)
            {
                Time.timeScale = 0f;
                pauseMenu.SetActive(true);
                Cursor.visible = true;
            }
            else
            {
                Time.timeScale = 1f;
                pauseMenu.SetActive(false);
                Cursor.visible = false;
            }
        }
    }

    // For quitting the game.
    public void quit()
    {
        Application.Quit();
    }

    // Resumes the game by pressing the button with this method.
    public void resume()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
        Cursor.visible = false;
    }

}
