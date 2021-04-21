using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Логика кнопок из сцены меню
/// </summary>
public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.sceneLoaded += LoadGameScene.GetLoadGameScene().WhenSceneFinillyLoaded;
        SceneManager.LoadSceneAsync(ObjectsInfo.SceneInfo.GameSceneID, LoadSceneMode.Single);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
