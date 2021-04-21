using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Игровое меню
/// </summary>
public class InGameMenu : MonoBehaviour
{
    #region Fields
    public static bool GameIsPaused = false;
    public static bool GameIsEnd = false;

    public GameObject pauseMenuUI;
    public GameObject endMenuUI;
    #endregion

    #region Base methods
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

        if (GameIsEnd)
        {
            GameOver();
        }
    }
    #endregion

    #region Custom methods
    private void GameOver()
    {
        endMenuUI.SetActive(true);
        GameIsEnd = false;
    }

    public void Resume()
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
        if (Time.timeScale == 0f) Time.timeScale = 1f;

        SceneManager.sceneLoaded -= LoadGameScene.GetLoadGameScene().WhenSceneFinillyLoaded;
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(ObjectsInfo.SceneInfo.MenuSceneID, LoadSceneMode.Single);
    }

    public void QuitGame()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif

        Application.Quit();
    }

    public void Restart()
    {
        ScoreScript.scoreValue = 0;
        SceneManager.LoadSceneAsync(ObjectsInfo.SceneInfo.GameSceneID, LoadSceneMode.Single);
    }
    #endregion
}
