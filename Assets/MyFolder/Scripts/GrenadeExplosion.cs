using System;
using UnityEngine;

public class GrenadeExplosion : MonoBehaviour
{
        [SerializeField] private float _upwardsModifier;
        [SerializeField] private float _power;
        [SerializeField] private float _radius;
        [SerializeField] private float _timeBeforeExplosion = 1.5f;
        [SerializeField] private ParticleSystem _explosionEffect;
        private AudioSource _audioSource;
        private AudioClip _explosionAudio;
        private Rigidbody _rigidbody;
        
        private void Start()
        {
                _rigidbody = GetComponent<Rigidbody>();
                Invoke(nameof(Explosion), _timeBeforeExplosion);
        }

        private void Explosion()
        {
                _rigidbody.AddExplosionForce(_power, transform.position, _radius, _upwardsModifier, ForceMode.Impulse);
                _explosionEffect?.Play();
                _audioSource?.PlayOneShot(_explosionAudio);
                Destroy(gameObject);
        }
}