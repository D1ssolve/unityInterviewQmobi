using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGameScene
{
    public static LoadGameScene LoadGameSceneObject;

    public static LoadGameScene GetLoadGameScene()
    {
        if (LoadGameSceneObject is null)
        {
            LoadGameSceneObject = new LoadGameScene();
        }

        return LoadGameSceneObject;
    }

    public void WhenSceneFinillyLoaded(Scene scene, LoadSceneMode mode)
    {
        //gameobject or null?

        InitializationStartObjects initializationStartObjects = new InitializationStartObjects();

        initializationStartObjects.Initialize();
    }

    //public void RestartGame(Scene scene)
    //{
    //    SceneManager.sceneUnloaded -= GetLoadGameScene().RestartGame;

    //    SceneManager.sceneLoaded += GetLoadGameScene().WhenSceneFinillyLoaded;

    //    SceneManager.LoadSceneAsync(ObjectsInfo.GameSceneID, LoadSceneMode.Single);
    //}
}
