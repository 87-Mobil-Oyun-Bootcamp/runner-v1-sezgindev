using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
   [SerializeField] private Transform _playerTransform;
   [SerializeField] private PlayerSettings _playerSettings;
   [SerializeField] private float _swerveSpeed=3.0f;
   private bool _isRunning;
   [SerializeField] private InputManager _inputManager;

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
       if (_isRunning)
       {
         //  _playerTransform.position += ;
           float swerveAmount = Time.deltaTime*_swerveSpeed*_inputManager.MoveFactorX;
           transform.Translate( swerveAmount,0,(_playerSettings.Speed * Time.deltaTime));
       }
   
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
