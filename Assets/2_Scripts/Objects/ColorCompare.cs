using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorCompare : MonoSingleton<ColorCompare>
{
    [SerializeField] Image TargetColorImg;
    Color endColorDiff;
    public float successPercentage;

    private void OnEnable()
    {
        EventManager.OnLevelEnd.AddListener(CompareColors);

    }

    private void OnDisable()
    {
        EventManager.OnLevelEnd.RemoveListener(CompareColors);
    }

    // Compare colors when the level is over
    public void CompareColors()
    {
        endColorDiff = Player.Instance.SkinnedMeshRenderer.materials[0].color - TargetColorImg.color;
        Debug.Log(endColorDiff);
        if (Mathf.Abs(endColorDiff.r) > 0.3f || Mathf.Abs(endColorDiff.g) > 0.3f || Mathf.Abs(endColorDiff.b) > 0.3f)
        {
            Debug.Log("GAME OVER!");
            CalculateSuccessPercentage(30);
            EventManager.OnLevelFail.Invoke();
        }
        else
        {
            Debug.Log("Congratulations!");
            CalculateSuccessPercentage(0);
            EventManager.OnLevelWin.Invoke();
        }
        
    }

    public void CalculateSuccessPercentage(int failurePoint)
    {
        float totalRGBValue = Mathf.Abs(endColorDiff.r) + Mathf.Abs(endColorDiff.g) + Mathf.Abs(endColorDiff.b);
        successPercentage = ((3 - totalRGBValue) * 33.3f) - failurePoint ;
        if (successPercentage<0)
        {
            successPercentage = 1;
        }
        Debug.Log(((int)successPercentage));
    }
}
