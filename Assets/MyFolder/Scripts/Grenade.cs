using System;
using UnityEngine;

public class Grenade : MonoBehaviour
{
    [SerializeField] private Transform _spawnPosition;
    [SerializeField] private Rigidbody _grenade;
    [SerializeField] private float _grenadeForwardForce;
    [SerializeField] private float _grenadeUpForce;
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            _animator.SetTrigger("Grenade");
        }
    }

    private void CreateGranade()
    {
        var bullet = Instantiate(_grenade, _spawnPosition.position, Quaternion.identity);
        bullet.AddForce((transform.up * _grenadeUpForce) + (transform.forward * _grenadeForwardForce),
            ForceMode.Impulse);
    }
}