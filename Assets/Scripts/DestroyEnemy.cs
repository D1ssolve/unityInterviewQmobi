using UnityEngine;
using System.Linq;

public class DestroyEnemy : MonoBehaviour
{
    public ParticleSystem explosion;

    public AudioClip detonation;

    private static readonly string cameraName = "Main Camera";


    // Update is called once per frame
    void Update()
    {
        
    }

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

        if (name == "Spaceship (1)")
        {
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(gameObject);
            Instantiate(explosion, collision.gameObject.transform.position, collision.gameObject.transform.rotation);
            Destroy(collision.gameObject);
        }
    }

    void PlaySound()
    {
        var cameraPosition = gameObject.scene.GetRootGameObjects()
                                             .FirstOrDefault(a => a.gameObject.name == cameraName).transform.position;

        AudioSource.PlayClipAtPoint(detonation, cameraPosition, 0.7f);
    }
}
