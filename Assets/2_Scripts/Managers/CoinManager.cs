using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoSingleton<CoinManager>
{
    public int coinCount;

    private void OnEnable()
    {
        coinCount = PlayerPrefs.GetInt("coinCount");
        EventManager.OnLevelWin.AddListener(UpdateCointCount);
    }

    private void OnDisable()
    {
        EventManager.OnLevelWin.AddListener(UpdateCointCount);
    }

    void UpdateCointCount()
    {
        coinCount += ((int)ColorCompare.Instance.successPercentage);
        PlayerPrefs.SetInt("coinCount", coinCount);
    }
}
