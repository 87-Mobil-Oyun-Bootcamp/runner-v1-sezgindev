using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class EventManager
{
    public static Action GameStarted;
    public static Action<bool> PlayerRunning;
    public static Action AddCoin;
    public static Action OnObstacleHit;

}
