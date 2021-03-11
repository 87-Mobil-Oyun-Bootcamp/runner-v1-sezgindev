using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour,ICollectable
{
    public void Interact()
    {
        Destroy(gameObject);
        GameManager.CoinAmount +=1;
        EventManager.AddCoin?.Invoke();
        Debug.Log("Coin Toplandı");
    }
}
