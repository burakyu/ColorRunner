using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    private void OnEnable()
    {
        EventManager.OnLevelStart.AddListener(CloseMainMenu);
    }

    private void OnDisable()
    {
        EventManager.OnLevelStart.RemoveListener(CloseMainMenu);
    }

    public void CloseMainMenu()
    {
        gameObject.SetActive(false);
    }
}
