using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
   [SerializeField] private Transform _playerTransform;
   [SerializeField] private PlayerSettings _playerSettings;
   private bool _isRunning;


   private void OnEnable()
   {
       EventManager.GameStarted += StartRunning;
   }

   private void OnDisable()
   {
       EventManager.GameStarted -= StartRunning;
   }

   private void Update()
   {
       if (!_isRunning) return;
       _playerTransform.position += Vector3.forward * (_playerSettings.Speed * Time.deltaTime);    
    }

   private void StartRunning()
   {
       _playerSettings.Speed = 2.3f;
       _isRunning = true;
       EventManager.PlayerRunning?.Invoke(_isRunning);
  
   }

   private void OnTriggerEnter(Collider  other)
   {
       ICollectable obj = other.GetComponent<ICollectable>();
       obj?.Interact();
   }
}
