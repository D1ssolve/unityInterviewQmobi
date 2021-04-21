using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCreator : MonoBehaviour, ICreator
{
    public void Create()
    {
        GameObject spawn = Resources.Load("Spawn") as GameObject;
        Instantiate(spawn, ObjectsInfo.SpawnVector3, ObjectsInfo.SpawnQuaternion);
    }
}
