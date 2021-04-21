using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCreator : MonoBehaviour, ICreator
{
    public void Create()
    {
        GameObject player = Resources.Load("Spaceship") as GameObject;
        Instantiate(player, ObjectsInfo.PlayerVector3, ObjectsInfo.PlayerQuaternion);
    }
}
