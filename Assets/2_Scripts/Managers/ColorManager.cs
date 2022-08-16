using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    public GameData GameData;

    private void OnEnable()
    {
        EventManager.OnDoorTriggered.AddListener(ColorChanger);
        //EventManager.OnLevelEnd.AddListener(CompareColors);

    }

    private void OnDisable()
    {
        EventManager.OnDoorTriggered.RemoveListener(ColorChanger);
        //EventManager.OnLevelEnd.RemoveListener(CompareColors);
    }

    // Change player's color when the player goes through the gate
    private void ColorChanger(Color gateColor)
    {
        Player.Instance.SkinnedMeshRenderer.materials[0].color = Color.Lerp(Player.Instance.SkinnedMeshRenderer.materials[0].color, gateColor, 0.4f);
        EventManager.OnColorChange.Invoke();
       // CompareColors();
    }

    
}
