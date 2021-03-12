using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool _isGameStarted;
    public static int CoinAmount;

    private void Start()
    {
        CoinAmount = 0;
    }

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
    public void TryAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
