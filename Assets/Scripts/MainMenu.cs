using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.sceneLoaded += LoadGameScene.GetLoadGameScene().WhenSceneFinillyLoaded;
        SceneManager.LoadSceneAsync(ObjectsInfo.GameSceneID, LoadSceneMode.Single);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
