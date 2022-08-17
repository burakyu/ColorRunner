using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using TMPro;

public class CanvasController : MonoSingleton<CanvasController>
{
    [SerializeField] GameObject finalUI;

    [SerializeField] GameObject winMenu;
    [SerializeField] TextMeshProUGUI winMenuAccurateText;

    [SerializeField] GameObject failMenu;
    [SerializeField] TextMeshProUGUI failMenuAccurateText;

    [SerializeField] TextMeshProUGUI winningCoinCountText;

    private void OnEnable()
    {
        finalUI.gameObject.SetActive(false);
        winMenu.gameObject.SetActive(false);
        failMenu.gameObject.SetActive(false);
        EventManager.OnLevelEnd.AddListener(OpenFinalUI);
        EventManager.OnLevelWin.AddListener(OpenWinMenu);
        EventManager.OnLevelFail.AddListener(OpenFailMenu);
        EventManager.OnLevelChange.AddListener(CloseAllMenus);
        DontDestroyOnLoad(this.gameObject);
    }

    private void OnDisable()
    {
        EventManager.OnLevelEnd.RemoveListener(OpenFinalUI);
        EventManager.OnLevelWin.RemoveListener(OpenWinMenu);
        EventManager.OnLevelFail.RemoveListener(OpenFailMenu);
        EventManager.OnLevelChange.AddListener(CloseAllMenus);

    }

    void OpenFinalUI()
    {
        finalUI.gameObject.SetActive(true);
    }

    void OpenWinMenu()
    {
        StartCoroutine(OpenWinMenuCo());
        winMenuAccurateText.text = (int)ColorCompare.Instance.successPercentage + "% Accurate";
        winningCoinCountText.text = "+" + (int)ColorCompare.Instance.successPercentage;
    }
    IEnumerator OpenWinMenuCo()
    {
        yield return new WaitForSeconds(3.5f);
        winMenu.gameObject.SetActive(true);
    }
    
    void OpenFailMenu()
    {
        StartCoroutine(OpenFailMenuCo());
        failMenuAccurateText.text = (int)ColorCompare.Instance.successPercentage + "% Accurate";
    }
    IEnumerator OpenFailMenuCo()
    {
        yield return new WaitForSeconds(3.5f);
        failMenu.gameObject.SetActive(true);
    }

    void CloseAllMenus()
    {
        failMenu.SetActive(false);
        winMenu.SetActive(false);
        finalUI.SetActive(false);
    }
}
