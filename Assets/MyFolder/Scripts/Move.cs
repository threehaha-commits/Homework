using System;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        var vertical = Input.GetAxis("Vertical") * _speed * Time.deltaTime;
        transform.Translate(0f, 0f, vertical);
        PlayAnimation(vertical);
    }

    private void PlayAnimation(float vertical)
    {
        var inputVertical = !Mathf.Approximately(vertical, 0f);
        var isMove = inputVertical;
        _animator.SetBool("IsWalking", isMove);
    }
}