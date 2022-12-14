using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayersColorImage : MonoBehaviour
{
    Image imageColor;

    private void OnEnable()
    {
        EventManager.OnColorChange.AddListener(UpdateColor);
    }
    
    private void OnDisable()
    {
        EventManager.OnColorChange.RemoveListener(UpdateColor);
    }

    private void Start()
    {
        imageColor = GetComponent<Image>();
        UpdateColor();
    }

    //Update current color on UI
    public void UpdateColor()
    {
        Color playersColor = new Color(Player.Instance.SkinnedMeshRenderer.materials[0].color.r, Player.Instance.SkinnedMeshRenderer.materials[0].color.g, Player.Instance.SkinnedMeshRenderer.materials[0].color.b, 1);
        imageColor.color = playersColor;
    }
}
