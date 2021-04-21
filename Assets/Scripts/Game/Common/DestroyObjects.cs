using UnityEngine;
using System.Linq;

public class DestroyObjects : MonoBehaviour
{
    #region Fields
    /// <summary>
    /// <remarks>������� ������ ����������� � ��������������� ���������� ������.</remarks>
    /// <para>������ ������.</para>
    /// </summary>
    public ParticleSystem explosion;

    /// <summary>
    /// <remarks>��������������� �������� �������.</remarks>
    /// <para>���� ������.</para>
    /// </summary>
    public AudioClip detonation;

    /// <summary>
    /// ������������ ������� ������ �����.
    /// </summary>
    private static readonly string cameraName = "Main Camera";
    #endregion

    /// <summary>
    /// ���������� ����� ������� ������� � ���������, ������������� � ����� �������.
    /// </summary>
    /// <param name="collision">Collider ������� ������� ������������ � ������������.</param>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var name = collision.gameObject.name;

        if (name == "Bullet(Clone)")
        {
            PlaySound();
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(gameObject);
            ScoreScript.scoreValue++;
            Destroy(collision.gameObject);
        }

        if (name == "Spaceship(Clone)")
        {
            PlaySound();
            PlaySound();
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(gameObject);
            Instantiate(explosion, collision.gameObject.transform.position, collision.gameObject.transform.rotation);
            Destroy(collision.gameObject);

            InGameMenu.GameIsEnd = true;
        }
    }

    /// <summary>
    /// ������������ �����-������� ������
    /// </summary>
    void PlaySound()
    {
        var cameraPosition = gameObject.scene.GetRootGameObjects()
                                             .FirstOrDefault(a => a.gameObject.name == cameraName).transform.position;

        AudioSource.PlayClipAtPoint(detonation, cameraPosition, 3f);
    }
}
