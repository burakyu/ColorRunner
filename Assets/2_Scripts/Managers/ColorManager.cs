using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoSingleton<ColorManager>
{
    private void OnEnable()
    {
        EventManager.OnGateTriggered.AddListener(ColorChanger);
    }

    private void OnDisable()
    {
        EventManager.OnGateTriggered.RemoveListener(ColorChanger);
    }

    // Change player's color when the player goes through the gate
    private void ColorChanger(Color gateColor)
    {
        Player.Instance.SkinnedMeshRenderer.materials[0].color = Color.Lerp(Player.Instance.SkinnedMeshRenderer.materials[0].color, gateColor, 0.4f);
        EventManager.OnColorChange.Invoke();
    }

    
}
