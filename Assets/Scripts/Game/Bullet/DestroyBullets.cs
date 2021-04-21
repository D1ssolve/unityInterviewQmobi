using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullets : MonoBehaviour
{
    /// <summary>
    /// Обработчик входа другого объекта в коллайдер, прикрепленный к этому объекту.
    /// </summary>
    /// <param name="collision">Collider другого объекта участвующего в столкновении.</param>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var name = collision.gameObject.name;

        if (name == "Bullet(Clone)")
        {
            Destroy(gameObject);
            ScoreScript.scoreValue++;
            Destroy(collision.gameObject);
        }
    }
}
