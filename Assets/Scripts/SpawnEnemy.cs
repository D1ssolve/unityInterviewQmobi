using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemy;
    public float spawnTime = 2.0f;
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(AddEnemy), spawnTime, spawnTime);
    }

    void AddEnemy()
    {
        float x1 = transform.position.x - GetComponent<Renderer>().bounds.size.x / 2;
        float x2 = transform.position.x + GetComponent<Renderer>().bounds.size.x / 2;

        Vector2 spawnPoint = new Vector2(Random.Range(x1, x2), transform.position.y);

        GameObject enemySoldier = Instantiate(enemy, spawnPoint, Quaternion.identity);

        enemySoldier.TryGetComponent<Movement>(out var a);

        AccelerationByScore(a);

        if (target != null)
        {
            a.target = target;
        }
    }

    int deltaScore = 1;
    int riseCounter = 1;

    private void AccelerationByScore(Movement movement)
    {
        int score = ScoreScript.scoreValue;

        if (score != 0 && score % deltaScore == 0)
        {
            movement.speed += 50 * riseCounter;
            deltaScore += 1;
            riseCounter++;
        }
    }
}