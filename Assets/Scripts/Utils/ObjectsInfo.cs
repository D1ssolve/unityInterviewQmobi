using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Справочные данные
/// </summary>
public static class ObjectsInfo
{
    #region Fields

    public static readonly string CameraName = "Main Camera";

    #region GameZoneLimits
    public static float MinXPosition => 105f;
    public static float MaxXPosition => 1810f;
    public static float MinYPosition => 90f;
    public static float MaxYPosition => 990f;
    #endregion

    #region Positions
    public static Vector3 PlayerVector3 => new Vector3(959f, 493f, 0f);
    public static Quaternion PlayerQuaternion => new Quaternion(0f, 0f, 0f, 0f);
    public static Vector3 SpawnVector3 => new Vector3(963.8755f, 1066.942f, 0f);
    public static Quaternion SpawnQuaternion => new Quaternion(0f, 0f, 0f, 0f);
    #endregion

    #endregion

    #region 
    /// <summary>
    /// Набор IDs сцен
    /// </summary>
    public static class SceneInfo
    {
        public static int MenuSceneID => 0;
        public static int GameSceneID => 1;
        public static int LoadingSceneID => 2;
    }
    #endregion
}
