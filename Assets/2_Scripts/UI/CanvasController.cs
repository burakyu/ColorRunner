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
        EventManager.OnLevelEnd.AddListener(OpenFinalUI);
    }

    private void OnDisable()
    {
        EventManager.OnLevelEnd.RemoveListener(OpenFinalUI);
    }

    void OpenFinalUI()
    {
        //Debug.Log("game is end");
        finalUI.gameObject.SetActive(true);
        
        //////successPercentageSlider.value = Mathf.Lerp(0, ColorCompare.Instance.successPercentage, 5 *Time.deltaTime);
    }
}
