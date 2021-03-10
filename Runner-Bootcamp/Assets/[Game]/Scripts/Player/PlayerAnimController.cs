﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimController : MonoBehaviour
{
    private Animator _playerAnimator;
    private readonly int _runningAnim = Animator.StringToHash("isRunning");

    void Awake()
    {
        _playerAnimator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        EventManager.PlayerRunning += RunningAnim;
    }

    private void OnDisable()
    {
        EventManager.PlayerRunning -= RunningAnim;
    }

    private void RunningAnim(bool isRunning) => _playerAnimator.SetBool(_runningAnim, isRunning);

}