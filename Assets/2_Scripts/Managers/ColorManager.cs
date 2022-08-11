using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    Color endColorDiff;

    Color deneme;

    private void OnEnable()
    {
        EventManager.OnDoorTriggered.AddListener(ColorChanger);
        EventManager.OnLevelEnd.AddListener(CompareColors);

        ColorUtility.TryParseHtmlString("#FF2A6A", out deneme);

    }

    private void OnDisable()
    {
        EventManager.OnDoorTriggered.RemoveListener(ColorChanger);
        EventManager.OnLevelEnd.RemoveListener(CompareColors);
    }

    // Change player's color when the player goes through the gate
    private void ColorChanger(Color gateColor)
    {
        Debug.Log("BBBBBBB");
        Player.Instance.SkinnedMeshRenderer.materials[0].color = Color.Lerp(Player.Instance.SkinnedMeshRenderer.materials[0].color, gateColor, 0.4f);
        EventManager.OnColorChange.Invoke();
        CompareColors();
    }

    // Compare colors when the level is over
    public void CompareColors()
    {
        endColorDiff = Player.Instance.SkinnedMeshRenderer.materials[0].color - deneme;
        Debug.Log(endColorDiff);
        if (Mathf.Abs(endColorDiff.r) > 0.3f || Mathf.Abs(endColorDiff.g) > 0.3f || Mathf.Abs(endColorDiff.b) > 0.3f)
        {
            Debug.Log("GAME OVER!");
        }
        else
        {
            Debug.Log("Congratulations!");
        }
    }
}
