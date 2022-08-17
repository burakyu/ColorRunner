using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FinalUI : MonoBehaviour
{
    [SerializeField] Slider successPercentageSlider;
    [SerializeField] TextMeshProUGUI successPercentageText;

    // Update is called once per frame
    void Update()
    {
        if (successPercentageSlider.value < ColorCompare.Instance.successPercentage / 100)
        {
            successPercentageSlider.value += 0.5f * Time.deltaTime;
            successPercentageText.text = ((int)ColorCompare.Instance.successPercentage) + "%";
        }
    }
}
