using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUI : MonoBehaviour
{
    private void OnEnable()
    {
        EventManager.OnLevelWin.AddListener(CloseGameUI);
        EventManager.OnLevelFail.AddListener(CloseGameUI);
    }

    private void OnDisable()
    {
        EventManager.OnLevelWin.AddListener(CloseGameUI);
        EventManager.OnLevelFail.AddListener(CloseGameUI);
    }

    void CloseGameUI()
    {
        StartCoroutine(CloseGameUICo());
    }
    
    IEnumerator CloseGameUICo()
    {
        yield return new WaitForSeconds(3.5f);
        gameObject.SetActive(false);
    }
}
