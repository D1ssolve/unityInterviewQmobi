using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InitializationStartObjects : MonoBehaviour
{
    public void Initialize()
    {
        //gameobject or null?
        new PlayerCreator().Create();

        new SpawnCreator().Create();
    }
}
