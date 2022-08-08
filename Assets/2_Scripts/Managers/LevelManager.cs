using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadSceneCo());
    }

    private IEnumerator LoadSceneCo()
    {
        yield return SceneManager.LoadSceneAsync("Level01", LoadSceneMode.Additive);
    }
}
