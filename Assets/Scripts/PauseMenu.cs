using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    /// <summary>
    /// Наименование объекта камеры сцены.
    /// </summary>
    private static readonly string cameraName = "Main Camera";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            var audio = gameObject.scene.GetRootGameObjects()
                                        .FirstOrDefault(a => a.gameObject.name == cameraName).GetComponent<AudioSource>();
            if (GameIsPaused)
            {
                audio.mute = true;
                Resume();
            }
            else
            {
                audio.mute = false;
                Pause();
            }
        }
    }

    public  void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    private void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        Debug.Log("Loading menu...");
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game");
        Application.Quit();
    }
}
