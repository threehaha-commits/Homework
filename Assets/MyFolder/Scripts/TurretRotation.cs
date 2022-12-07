using UnityEngine;

public class TurretRotation : MonoBehaviour
{
    private Transform _player;

    private void Start()
    {
        _player = GameObject.FindWithTag("Player").transform;
    }

    private void Update()
    {
        var direction = transform.position - _player.position;
        transform.rotation = Quaternion.LookRotation(direction, Vector3.up); 
    }
}