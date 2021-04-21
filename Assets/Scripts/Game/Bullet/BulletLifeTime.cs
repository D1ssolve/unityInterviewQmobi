using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLifeTime : MonoBehaviour
{
    public Sprite sprite;

    public float maxDistanse;
    Vector3 startPos;
    Vector3 carentPos;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        carentPos = transform.position;

        if (Vector3.Distance(startPos, carentPos) >= maxDistanse)
        {
            gameObject.TryGetComponent<SpriteRenderer>(out var sr);
            
            sr.sprite = sprite;

            gameObject.TryGetComponent<Rigidbody2D>(out var rb);

            rb.velocity = Vector3.zero;
            rb.angularVelocity = 0f;

            Destroy(gameObject, 0.2f);
        }
    }
}
