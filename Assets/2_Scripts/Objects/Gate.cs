using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    Color gateColor;

    private void Start()
    {
        gateColor = GetComponent<Renderer>().material.color;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            EventManager.OnDoorTriggered.Invoke(gateColor);
        }
    }

    
}
