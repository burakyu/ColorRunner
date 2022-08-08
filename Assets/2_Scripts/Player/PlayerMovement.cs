using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : Player
{
    private Vector3 mousePressDownPos;
    private Vector3 mouseReleasePos;
    public float playerSpeed;
    public float xRange;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed);

        if (Input.GetMouseButtonDown(0))
        {
            mousePressDownPos = Input.mousePosition;
        }
        else if (Input.GetMouseButton(0))
        {
            mouseReleasePos = Input.mousePosition;
            Movement(mouseReleasePos.x - mousePressDownPos.x);
        }
        else if (Input.GetMouseButtonUp(0))
        {
            mousePressDownPos = Vector3.zero;
            mouseReleasePos = Vector3.zero;
        }

        SetMovementRange();
    }

    void Movement(float xDiff)
    {
        transform.Translate(xDiff * Time.deltaTime * playerSpeed * Vector3.right / 100);
    }

    void SetMovementRange()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -xRange, xRange), transform.position.y, transform.position.z);
    }
}
