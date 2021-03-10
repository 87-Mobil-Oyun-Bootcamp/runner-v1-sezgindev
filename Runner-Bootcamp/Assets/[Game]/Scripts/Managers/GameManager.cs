﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool _isGameStarted;
    private void Update()
    {
        if (!_isGameStarted)
        {
            if (Input.GetMouseButtonDown(0))
            {
                EventManager.GameStarted?.Invoke();
                _isGameStarted = true;
            }
        }
    }
}
