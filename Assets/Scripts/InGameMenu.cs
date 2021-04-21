using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameMenu : MonoBehaviour
{
    #region Fields
    public static bool GameIsPaused = false;
    public static bool GameIsEnd = false;

    public GameObject pauseMenuUI;
    public GameObject endMenuUI;
    #endregion

    /// <summary>
    /// ������������ ������� ������ �����.
    /// </summary>
    private static readonly string cameraName = "Main Camera";

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

        if (GameIsEnd)
        {
            GameOver();
        }
    }

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
        ScoreScript.scoreValue = 0;

        SceneManager.sceneLoaded -= LoadGameScene.GetLoadGameScene().WhenSceneFinillyLoaded;
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(ObjectsInfo.MenuSceneID, LoadSceneMode.Single);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

    public void Restart()
    {
        ScoreScript.scoreValue = 0;

        //SceneManager.sceneLoaded -= LoadGameScene.GetLoadGameScene().WhenSceneFinillyLoaded;
        //SceneManager.LoadSceneAsync(ObjectsInfo.LoadingSceneID);

        //SceneManager.sceneUnloaded += LoadGameScene.GetLoadGameScene().RestartGame;
        //SceneManager.UnloadSceneAsync(ObjectsInfo.GameSceneID);
        SceneManager.LoadSceneAsync(ObjectsInfo.GameSceneID, LoadSceneMode.Single);
    }
}
