using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Confetti : MonoBehaviour
{
    [SerializeField] GameObject confettis;
    private void OnEnable()
    {
        confettis.gameObject.SetActive(false);
        EventManager.OnLevelWin.AddListener(PlayConfetti);
    }

    private void OnDisable()
    {
        EventManager.OnLevelWin.AddListener(PlayConfetti);
    }

    void PlayConfetti()
    {
        StartCoroutine(PlayConfettiCo());
    }

    IEnumerator PlayConfettiCo()
    {
        yield return new WaitForSeconds(1);
        confettis.gameObject.SetActive(true);
    }
}
