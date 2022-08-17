using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public static class EventManager 
{
    public static UnityEvent OnLevelEnd = new UnityEvent();
    public static UnityEvent OnLevelStart = new UnityEvent();
    public static UnityEvent OnLevelWin = new UnityEvent();
    public static UnityEvent OnLevelFail = new UnityEvent();
    public static UnityEvent OnLevelChange = new UnityEvent();
    public static UnityEvent<Color> OnGateTriggered = new UnityEvent<Color>();
    public static UnityEvent OnColorChange = new UnityEvent();
}