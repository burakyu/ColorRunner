using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinTextController : MonoBehaviour
{
    private TextMeshProUGUI coinText;

    private void OnEnable()
    {
        coinText = GetComponent<TextMeshProUGUI>();
        EventManager.OnLevelWin.AddListener(UpdateCoinText);
        coinText.text = CoinManager.Instance.coinCount.ToString();
    }

    private void OnDisable()
    {
        EventManager.OnLevelWin.RemoveListener(UpdateCoinText);
    }

    void UpdateCoinText()
    {
        StartCoroutine(UpdateCoinTextCo());
    }
    
    IEnumerator UpdateCoinTextCo()
    {
        yield return new WaitForSeconds(2f);
        coinText.text = CoinManager.Instance.coinCount.ToString();
    }
}
