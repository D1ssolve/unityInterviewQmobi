using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// ������������� ������� �����
/// </summary>
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

    /// <summary>
    /// ���������� - SceneManager.sceneLoaded
    /// </summary>
    public void WhenSceneFinillyLoaded(Scene scene, LoadSceneMode mode)
    {
        //gameobject or null?

        new PlayerCreator().Create();
        new SpawnCreator().Create();
    }
}
