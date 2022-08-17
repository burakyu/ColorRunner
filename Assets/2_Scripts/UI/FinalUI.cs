using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FinalUI : MonoBehaviour
{
    [SerializeField] Slider successPercentageSlider;
    [SerializeField] TextMeshProUGUI successPercentageText;
    private void OnEnable()
    {
        EventManager.OnLevelChange.AddListener(resetSlider);
    }

    private void OnDisable()
    {
        EventManager.OnLevelChange.RemoveListener(resetSlider);
    }

    // Update is called once per frame
    void Update()
    {
        if (successPercentageSlider.value < ColorCompare.Instance.successPercentage / 100)
        {
            successPercentageSlider.value += 1f * Time.deltaTime;
            successPercentageText.text = ((int)ColorCompare.Instance.successPercentage) + "%";
        }
    }

    void resetSlider()
    {
        successPercentageSlider.value = 0;
    }
}
