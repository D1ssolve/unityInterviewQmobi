using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FabricMethod : MonoBehaviour
{
    public enum TypesObject
    {
        Player,
        Spawn
    }

    public void Creator(TypesObject typeObject)
    {
        /*InitializationStartObjects initializationStartObjects = gameObject.AddComponent<InitializationStartObjects>()*/;

        var initializationStartObjects = new InitializationStartObjects();

        switch (typeObject)
        {
            case TypesObject.Player:
                initializationStartObjects.CreatePlayerObject();
                break;
            case TypesObject.Spawn:
                initializationStartObjects.CreateSpawnObject();
                break;
            default:
                break;
        }
    }

}
