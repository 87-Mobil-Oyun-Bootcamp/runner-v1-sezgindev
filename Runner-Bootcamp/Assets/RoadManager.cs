using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadManager : MonoBehaviour
{
    [SerializeField] private GameObject _road;
    [SerializeField] private Transform _playerTransform;
    private float _spawnZ = 101.6f;
    private float _roadLength = 22.07871f;
    private int _amnTileOnScreen = 1;
    void Start()
    {
        for (int i = 0; i < _amnTileOnScreen; i++)
        {
            SpawnRoad();
        }
   
    }

    // Update is called once per frame
    void Update()
    {
        if (_playerTransform.localPosition.z > (_spawnZ - _amnTileOnScreen *( _roadLength+11.0f)))
        {
            SpawnRoad();
        }
    }

    private void SpawnRoad()
    {
     
        GameObject go;
        go=Instantiate(_road) as GameObject;
        go.transform.SetParent(transform);
        go.transform.position = Vector3.forward * (_spawnZ) ;
        _spawnZ += _roadLength;

    }
}
