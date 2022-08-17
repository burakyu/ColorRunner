using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour
{
    void Start()
    {
        //Don't Destroy On Load parent object of all managers
        DontDestroyOnLoad(this.gameObject);
    }
}
