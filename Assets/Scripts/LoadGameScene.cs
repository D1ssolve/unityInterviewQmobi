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
        //gameobject ?

        var fabricMethod = new FabricMethod();
        fabricMethod.Creator(FabricMethod.TypesObject.Player);
        fabricMethod.Creator(FabricMethod.TypesObject.Spawn);
    }
}
