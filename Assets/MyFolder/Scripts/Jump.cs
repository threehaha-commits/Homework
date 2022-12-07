using System.Collections;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private float _height;
    private Rigidbody _rb;
    [SerializeField] private AnimationCurve _curve;
    
    
    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(DoJump());
        }
    }

    private IEnumerator DoJump()
    {
        float expiredTime = 0f;
        float progress = 0f;
        Vector3 startPosition = transform.position;
        while (progress<1)
        {
            expiredTime += Time.deltaTime;
            progress = expiredTime / _duration;
            transform.position = new Vector3(transform.position.x, startPosition.y + _curve.Evaluate(progress) * _height, transform.position.z);   
            yield return null;
        }
    }
}