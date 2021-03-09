using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Runner.Camera
{
    public class CameraController : MonoBehaviour
    {


        [SerializeField] private Transform _playerTransform;
        [SerializeField] private CameraSettings _cameraSettings;

        void LateUpdate()
        {
            transform.position = _playerTransform.position - _cameraSettings.CameraOffset;
        }
    }
}
