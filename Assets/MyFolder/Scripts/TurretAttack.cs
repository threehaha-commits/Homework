using System;
using UnityEngine;

public class TurretAttack : MonoBehaviour
{
    private Transform _player;
    [SerializeField] private Rigidbody _bullet;
    [SerializeField] private float _distForAttack;
    [SerializeField] private Transform _spawnPosition;
    [SerializeField] private float _destroyTime;
    [SerializeField] private float _bulletForce;
    [SerializeField] private float _reloadTime;
    private float _currentReloadTime;
    
    private void Start()
    {
        _player = GameObject.FindWithTag("Player").transform;
    }

    private void FixedUpdate()
    {
        var dist = (transform.position - _player.position).sqrMagnitude;
        if (dist < _distForAttack)
        {
            if(_currentReloadTime >= _reloadTime)
            {
                var bullet = Instantiate(_bullet, _spawnPosition.position, Quaternion.identity);
                bullet.AddForce(-_spawnPosition.forward * _bulletForce, ForceMode.Impulse);
                Destroy(bullet.gameObject, _destroyTime);
                _currentReloadTime = 0;
            }
            else
            {
                _currentReloadTime += Time.fixedDeltaTime;
            }
        }
    }
}