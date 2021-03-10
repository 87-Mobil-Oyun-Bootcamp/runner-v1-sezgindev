using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
   [SerializeField] private Transform _playerTransform;
   [SerializeField] private PlayerSettings _playerSettings;
   private bool _isRunning;
    void LateUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
           _playerTransform.position += Vector3.forward * (_playerSettings.Speed * Time.deltaTime);    
        }
                                                                                                                                                    
    }
}
