using UnityEngine;

public class Fire : MonoBehaviour
{
    [SerializeField] private Transform _spawnPosition;
    [SerializeField] private Rigidbody _bullet;
    [SerializeField] private float _bulletForce;
    [SerializeField] private float _destroyTime;
    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var bullet = Instantiate(_bullet, _spawnPosition.position, Quaternion.identity);
            bullet.AddForce(transform.forward * _bulletForce, ForceMode.Impulse);
            Destroy(bullet.gameObject, _destroyTime);
        }
    }
}