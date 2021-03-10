using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu (menuName = "Player/PlayerSetings")]
public class PlayerSettings : ScriptableObject
{
    [SerializeField] private float _speed;

    public float Speed
    {
        get => _speed;
        set => _speed = value;
    }
}
