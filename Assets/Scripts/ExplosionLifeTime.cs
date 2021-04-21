using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionLifeTime : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ParticleSystem parts = gameObject.GetComponent<ParticleSystem>();
        float totalDuration = parts.main.duration + parts.main.startLifetimeMultiplier;
        Destroy(gameObject, totalDuration);
    }
}
