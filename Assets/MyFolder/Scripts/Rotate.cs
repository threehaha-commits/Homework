using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;
    
    private void Update()
    {
        var horizontal = Input.GetAxis("Horizontal") * _rotationSpeed * Time.deltaTime;
        transform.Rotate(0f, horizontal, 0f);
    }
}