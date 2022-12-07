using UnityEngine;

public class Grenade : MonoBehaviour
{
    [SerializeField] private Transform _spawnPosition;
    [SerializeField] private Rigidbody _grenade;
    [SerializeField] private float _grenadeForwardForce;
    [SerializeField] private float _grenadeUpForce;

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            var bullet = Instantiate(_grenade, _spawnPosition.position, Quaternion.identity);
            bullet.AddForce((transform.up * _grenadeUpForce) + (transform.forward * _grenadeForwardForce),
                ForceMode.Impulse);
        }
    }

}