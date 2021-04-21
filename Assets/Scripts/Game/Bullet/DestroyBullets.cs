using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullets : MonoBehaviour
{
    /// <summary>
    /// ���������� ����� ������� ������� � ���������, ������������� � ����� �������.
    /// </summary>
    /// <param name="collision">Collider ������� ������� ������������ � ������������.</param>
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
