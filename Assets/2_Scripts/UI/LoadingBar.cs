using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingBar : MonoBehaviour
{
    private Slider slider;

    public float fillSpeed = 0.5f;
    private float targetProgress = 1;

    bool isGameStart;

    // Start is called before the first frame update
    void Start()
    {
        slider = gameObject.GetComponent<Slider>();
        isGameStart = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.value < targetProgress)
        {
            slider.value += fillSpeed * Time.deltaTime;
        }
        else if (slider.value == targetProgress && !isGameStart)
        {
            LevelManager.Instance.LoadScene();
            isGameStart = true;
        }
    }

}
