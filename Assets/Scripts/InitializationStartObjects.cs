using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InitializationStartObjects : MonoBehaviour
{
    public GameObject CreatePlayerObject()
    {
        GameObject player = Resources.Load("Spaceship") as GameObject;
        return Instantiate(player, ObjectsInfo.PlayerVector3, ObjectsInfo.PlayerQuaternion);
    }

    public GameObject CreateSpawnObject()
    {
        GameObject spawn = Resources.Load("Spawn") as GameObject;
        return Instantiate(spawn, ObjectsInfo.SpawnVector3, ObjectsInfo.SpawnQuaternion);
    }
}
