using System;
using TMPro;
using UnityEngine;

public class Fire : MonoBehaviour
{
    [SerializeField] private int _ammoCount;
    [SerializeField] private Transform _spawnPosition;
    [SerializeField] private Rigidbody _bullet;
    [SerializeField] private float _bulletForce;
    [SerializeField] private float _destroyTime;
    [SerializeField] private TMP_Text _ammoText;

    private void Start()
    {
        _ammoText.text = $"Ammo: {_ammoCount}";
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (_ammoCount <= 0)
                return;
            var bullet = Instantiate(_bullet, _spawnPosition.position, Quaternion.identity);
            bullet.AddForce(transform.forward * _bulletForce, ForceMode.Impulse);
            Destroy(bullet.gameObject, _destroyTime);
            _ammoCount--;
            _ammoText.text = $"Ammo: {_ammoCount}";
        }
    }
}