using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText;
    [SerializeField] private GameObject _tapToStartImage;
    [SerializeField] private GameObject _gameOverPanel;
    [SerializeField] private PlayerSettings _playerSettings;
    [SerializeField] private TextMeshProUGUI _gameOverScore;
    private void OnEnable()
    {
        EventManager.GameStarted += TapToStartDisable;
        EventManager.AddCoin += CoinIncrement;
        EventManager.OnObstacleHit += GameOver;
    }

    private void OnDisable()
    {
        EventManager.GameStarted -= TapToStartDisable;
        EventManager.AddCoin -= CoinIncrement;
        EventManager.OnObstacleHit -= GameOver;
    }
    
    private void TapToStartDisable()=>_tapToStartImage.SetActive(false);

    private void CoinIncrement()
    {
        _scoreText.SetText(GameManager.CoinAmount.ToString());
    }

    private void GameOver()
    {
        _playerSettings.Speed = 0;
        _gameOverScore.SetText("Score:"+ GameManager.CoinAmount);
       _gameOverPanel.SetActive(true);
    }
    
   
    
}
