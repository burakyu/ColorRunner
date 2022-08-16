using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FinalUI : MonoBehaviour
{
    [SerializeField] Slider successPercentageSlider;
    [SerializeField] TextMeshProUGUI successPercentageText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (successPercentageSlider.value < ColorCompare.Instance.successPercentage / 100)
        {
            successPercentageSlider.value += 0.5f * Time.deltaTime;
            successPercentageText.text = "%" + ((int)(successPercentageSlider.value * 100));
        }
        //else if (successPercentageSlider.value == ColorCompare.Instance.successPercentage / 100)
        //{
        //    //LevelManager.Instance.LoadScene();
        //}
    }
}
