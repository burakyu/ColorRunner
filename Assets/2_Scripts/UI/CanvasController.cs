using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class CanvasController : MonoSingleton<CanvasController>
{
    [SerializeField] GameObject finalUI;
    [SerializeField] GameObject winMenu;
    [SerializeField] GameObject failMenu;

    private void OnEnable()
    {
        finalUI.gameObject.SetActive(false);
        winMenu.gameObject.SetActive(false);
        failMenu.gameObject.SetActive(false);
        EventManager.OnLevelEnd.AddListener(OpenFinalUI);
        EventManager.OnLevelWin.AddListener(OpenWinMenu);
        EventManager.OnLevelFail.AddListener(OpenFailMenu);

    }

    private void OnDisable()
    {
        EventManager.OnLevelEnd.RemoveListener(OpenFinalUI);
        EventManager.OnLevelWin.RemoveListener(OpenWinMenu);
        EventManager.OnLevelFail.RemoveListener(OpenFailMenu);

    }

    void OpenFinalUI()
    {
        finalUI.gameObject.SetActive(true);
    }

    void OpenWinMenu()
    {
        StartCoroutine(OpenWinMenuCo());
    }
    IEnumerator OpenWinMenuCo()
    {
        yield return new WaitForSeconds(3.5f);
        winMenu.gameObject.SetActive(true);
    }
    
    void OpenFailMenu()
    {
        StartCoroutine(OpenFailMenuCo());
    }
    IEnumerator OpenFailMenuCo()
    {
        yield return new WaitForSeconds(3.5f);
        failMenu.gameObject.SetActive(true);
    }
}
