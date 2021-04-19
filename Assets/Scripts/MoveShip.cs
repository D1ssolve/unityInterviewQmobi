using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShip : MonoBehaviour
{
    public Rigidbody2D ship;

    public float moveSpeed = 20f;

    Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        ship.MovePosition(ship.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
