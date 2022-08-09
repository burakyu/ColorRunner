using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            Debug.Log(GetComponent<Renderer>().material.color);
            other.gameObject.GetComponent<Renderer>().material.color = GetComponent<Renderer>().material.color;
        }
    }
}
