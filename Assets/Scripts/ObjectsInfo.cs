using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ObjectsInfo
{
    #region Fields
    public static Vector3 PlayerVector3 => new Vector3(959f, 493f, 0f);

    public static Quaternion PlayerQuaternion => new Quaternion(0f, 0f, 0f, 0f);

    public static Vector3 SpawnVector3 => new Vector3(963.8755f, 1066.942f, 0f);

    public static Quaternion SpawnQuaternion => new Quaternion(0f, 0f, 0f, 0f);

    public static int MenuSceneID => 0;

    public static int GameSceneID => 1;

    public static int LoadingSceneID => 2;
    #endregion
}
