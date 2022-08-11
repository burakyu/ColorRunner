using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoSingleton<LevelManager>
{
    private int currentLevel;
    public int CurrentLevel { get { return currentLevel; } set { currentLevel = value; } }

    private int currentSceneIndex;
   // public int CurrentSceneIndex { get { return currentSceneIndex; } private set { currentSceneIndex = currentLevel % 4; } }

    private void OnEnable()
    {
        //PlayerPrefs.DeleteAll();
        //CurrentLevel = PlayerPrefs.GetInt("currentLevel");
        //currentSceneIndex = (currentLevel % 4) + 1;
        //if (SceneManager.GetActiveScene().buildIndex != (currentSceneIndex))
        //{
        //    SceneManager.LoadScene(currentSceneIndex);

        //}

        //Debug.Log(currentLevel);
    }

    private void Start()
    {
        //StartCoroutine(LoadSceneCo());
    }

    public void LoadScene()
    {
        CurrentLevel = PlayerPrefs.GetInt("currentLevel");
        currentSceneIndex = (currentLevel % 4) + 1;
        if (SceneManager.GetActiveScene().buildIndex != (currentSceneIndex))
        {
            SceneManager.LoadSceneAsync(currentSceneIndex);

        }

        Debug.Log(currentLevel);
        
    }

    public void NextLevel()
    {
        currentLevel++;
        PlayerPrefs.SetInt("currentLevel", currentLevel);
        currentSceneIndex = (currentLevel % 4) + 1;
        //Debug.Log(currentLevel);
        SceneManager.LoadScene(currentSceneIndex);
    }
    public void Restart()
    {
        SceneManager.LoadScene(currentSceneIndex);
    }
}
