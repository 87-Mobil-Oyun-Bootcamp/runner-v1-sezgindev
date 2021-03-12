using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour,ICollectable
{
    public void Interact()
    {
        EventManager.OnObstacleHit?.Invoke();
        Debug.Log("GameOver");
    }
}
