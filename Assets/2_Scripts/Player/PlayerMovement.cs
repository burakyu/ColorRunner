using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerMovement : Player
{
    private Vector3 mousePressDownPos;
    private Vector3 mouseReleasePos;
    public float verticalSpeed;
    public float horizontalSpeed;
    public float xRange;

    private void OnEnable()
    {
        EventManager.OnLevelWin.AddListener(LevelWinMovement);
        EventManager.OnLevelFail.AddListener(LevelFailMovement);
    }

    private void OnDisable()
    {
        EventManager.OnLevelWin.RemoveListener(LevelWinMovement);
        EventManager.OnLevelFail.RemoveListener(LevelFailMovement);
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

    void LevelWinMovement()
    {
        Animator.SetTrigger("IsGameWin");
        horizontalSpeed = 0;
        verticalSpeed = 0;
        transform.DORotate(new Vector3(0, 180, 0), 2);
        transform.DOMoveX(0, 1);
    }
    
    void LevelFailMovement()
    {
        Animator.SetTrigger("IsGameFail");
        horizontalSpeed = 0;
        verticalSpeed = 0;
        transform.DORotate(new Vector3(0, 180, 0), 2);
        transform.DOMoveX(0, 1);
    }
}
