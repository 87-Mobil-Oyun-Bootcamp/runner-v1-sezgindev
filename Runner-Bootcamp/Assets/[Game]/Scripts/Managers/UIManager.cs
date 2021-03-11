using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText;
    [SerializeField] private GameObject _tapToStartImage;
    private void OnEnable()
    {
        EventManager.GameStarted += TapToStartDisable;
        EventManager.AddCoin += CoinIncrement;
    }

    private void OnDisable()
    {
        EventManager.GameStarted += TapToStartDisable;
        EventManager.AddCoin += CoinIncrement;
    }
    
    private void TapToStartDisable()=>_tapToStartImage.SetActive(false);

    private void CoinIncrement()
    {
        _scoreText.SetText(GameManager.CoinAmount.ToString());
    }
    
    
}
