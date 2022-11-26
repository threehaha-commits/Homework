using System;
using UnityEngine;

public class BombExplosion : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            return;
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}