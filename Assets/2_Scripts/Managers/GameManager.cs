using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoSingleton<GameManager>
{
    //public GameData gameData;
    public bool isGameStart;
    public bool isGameEnd;
    // Start is called before the first frame update
    void Start()
    {
        isGameStart = false;
        isGameEnd = false;
    }

    private void OnEnable()
    {
        EventManager.OnLevelEnd.AddListener(StopTheGame);
    }

    private void OnDisable()
    {
        EventManager.OnLevelEnd.RemoveListener(StopTheGame);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isGameStart)
        {
            EventManager.OnLevelStart.Invoke();
            isGameStart = true;
        }
    }

    private void StopTheGame()
    {
        isGameEnd = true;
    }
}
