using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : Player
{
    private Vector3 mousePressDownPos;
    private Vector3 mouseReleasePos;
    public float verticalSpeed;
    public float horizontalSpeed;
    public float xRange;

    private void OnEnable()
    {
        EventManager.OnLevelEnd.AddListener(LevelEndMovement);
    }

    private void OnDisable()
    {
        EventManager.OnLevelEnd.RemoveListener(LevelEndMovement);
    }

    void Update()
    {
        if (GameManager.Instance.isGameStart == true && GameManager.Instance.isGameEnd == false)
        {
            Animator.SetTrigger("IsGameStart");
            transform.Translate(Vector3.forward * Time.deltaTime * verticalSpeed);

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
                Movement(0);
            }

            SetMovementRange();
        }
    }

    void Movement(float xDiff)
    {
        transform.Translate(xDiff * Time.deltaTime * horizontalSpeed * Vector3.right / 100);
    }

    void SetMovementRange()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -xRange, xRange), transform.position.y, transform.position.z);
    }

    void LevelEndMovement()
    {
        Animator.SetTrigger("IsGameEnd");
        horizontalSpeed = 0;
        verticalSpeed = 0;

    }
}
