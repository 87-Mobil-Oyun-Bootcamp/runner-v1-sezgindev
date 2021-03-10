using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimController : MonoBehaviour
{
    private Animator _playerAnimator;
    private readonly int _isRunning = Animator.StringToHash("isRunning");

    void Awake()
    {
        _playerAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (_playerAnimator.GetBool(_isRunning))
            {
                _playerAnimator.SetBool(_isRunning, false);
            }
            else
            {
                _playerAnimator.SetBool(_isRunning, true);
            }
        }
    }
}