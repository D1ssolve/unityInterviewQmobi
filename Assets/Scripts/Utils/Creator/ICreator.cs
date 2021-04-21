using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Интерфейс фабричного метода
/// </summary>
public interface ICreator
{
    /// <summary>
    /// Фабричный метод
    /// </summary>
    public abstract void Create();
}
