using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    Color gateColor;
    Color endColorDiff;

    Color deneme;

    private void Start()
    {
        gateColor = GetComponent<Renderer>().material.color;
        ColorUtility.TryParseHtmlString("#FF7400", out deneme);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            //Debug.Log(GetComponent<Renderer>().material.color);
            Player.Instance.MeshRenderer.material.color = Color.Lerp(Player.Instance.MeshRenderer.material.color, gateColor, 0.4f);

            endColorDiff = Player.Instance.MeshRenderer.material.color - deneme;
            Debug.Log(endColorDiff);
            CompareColors();
        }
    }

    public void CompareColors()
    {
        if (Mathf.Abs(endColorDiff.r)>0.3f || Mathf.Abs(endColorDiff.g) > 0.3f || Mathf.Abs(endColorDiff.b) > 0.3f)
        {
            Debug.Log("GAME OVER!");
        }
        else
        {
            Debug.Log("Congratulations!");
        }
    }
}
