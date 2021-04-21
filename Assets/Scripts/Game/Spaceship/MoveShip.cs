using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShip : MonoBehaviour
{
    #region Fields
    public Rigidbody2D ship;
    public float moveSpeed = 20f;
    Vector2 movement;
    #endregion

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        var deltaVector = ship.position + movement * moveSpeed * Time.fixedDeltaTime;

        if (ObjectsInfo.MinXPosition < deltaVector.x
            && ObjectsInfo.MaxXPosition > deltaVector.x
            && ObjectsInfo.MinYPosition < deltaVector.y
            && ObjectsInfo.MaxYPosition > deltaVector.y)
        {
            ship.MovePosition(deltaVector);
        }
    }
}
