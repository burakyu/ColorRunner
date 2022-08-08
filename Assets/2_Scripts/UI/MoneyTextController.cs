using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyTextController : MonoBehaviour
{
    private Text moneyText;
    public Text MoneyText
    {
        get
        {
            if (moneyText == null)
                moneyText = GetComponent<Text>();

            return moneyText;
        }
    }

    private void OnEnable()
    {
        EventManager.OnMissionDone.AddListener(UpdateMoneyText);
    }

    private void OnDisable()
    {
        EventManager.OnMissionDone.RemoveListener(UpdateMoneyText);
    }

    private void UpdateMoneyText()
    {
        int moneyCount = 0;
        MoneyText.text = moneyCount. ToString();
    }
}
