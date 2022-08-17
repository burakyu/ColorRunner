using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoSingleton<LevelManager>
{
    private int currentLevel;
    public int CurrentLevel { get { return currentLevel; } set { currentLevel = value; } }

    private int currentSceneIndex;

    public void LoadScene()
    {
        CurrentLevel = PlayerPrefs.GetInt("currentLevel");
        if ((currentLevel % 6) == 0)
        {
            currentLevel++;
        }
        currentSceneIndex = (currentLevel % 6);
        if (SceneManager.GetActiveScene().buildIndex != (currentSceneIndex))
        {
            SceneManager.LoadSceneAsync(currentSceneIndex);
            EventManager.OnLevelChange.Invoke();
        }
        GameManager.Instance.isGameStart = false;
        Debug.Log(currentLevel);
        
    }

    public void NextLevel()
    {
        currentLevel++;
        PlayerPrefs.SetInt("currentLevel", currentLevel);
        if ((currentLevel % 6) == 0)
        {
            currentLevel++;
        }
        currentSceneIndex = (currentLevel % 6);
        //Debug.Log(currentLevel);
        SceneManager.LoadScene(currentSceneIndex);
        EventManager.OnLevelChange.Invoke();
        GameManager.Instance.isGameStart = false;
    }
    public void Restart()
    {
        SceneManager.LoadScene(currentSceneIndex);
        EventManager.OnLevelChange.Invoke();
        GameManager.Instance.isGameStart = false;
    }
}
