using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoSingleton<LevelManager>
{
    private int currentLevel;
    public int CurrentLevel { get { return currentLevel; } set { currentLevel = value; } }

    private int currentSceneIndex;

    // Load scene when the starter scenes's loading bar full
    public void LoadScene()
    {
        CurrentLevel = PlayerPrefs.GetInt("currentLevel");
        if ((currentLevel % 4) == 0)
        {
            currentLevel++;
        }
        currentSceneIndex = (currentLevel % 4);
        if (SceneManager.GetActiveScene().buildIndex != (currentSceneIndex))
        {
            SceneManager.LoadSceneAsync(currentSceneIndex);
            EventManager.OnLevelChange.Invoke();
        }
        GameManager.Instance.isGameStart = false;
        Debug.Log(currentLevel);
    }

    // If the game is won, it advances to the next level.
    public void NextLevel()
    {
        currentLevel++;
        PlayerPrefs.SetInt("currentLevel", currentLevel);
        if ((currentLevel % 4) == 0)
        {
            currentLevel++;
        }
        currentSceneIndex = (currentLevel % 4);
        SceneManager.LoadScene(currentSceneIndex);
        EventManager.OnLevelChange.Invoke();
        GameManager.Instance.isGameStart = false;
    }

    //If the game is fails, it repeats the level.
    public void Restart()
    {
        SceneManager.LoadScene(currentSceneIndex);
        EventManager.OnLevelChange.Invoke();
        GameManager.Instance.isGameStart = false;
    }
}
