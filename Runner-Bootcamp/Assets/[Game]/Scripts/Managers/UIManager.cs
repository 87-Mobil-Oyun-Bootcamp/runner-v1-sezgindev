using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject _tapToStartImage;
    private void OnEnable()
    {
        EventManager.GameStarted += TapToStartDisable;
    }

    private void OnDisable()
    {
        EventManager.GameStarted += TapToStartDisable;
    }
    
    private void TapToStartDisable()
    {
        _tapToStartImage.SetActive(false);
    }
}
