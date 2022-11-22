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
        var horizontal = Input.GetAxis("Horizontal") * _speed * Time.deltaTime;
        var vertical = Input.GetAxis("Vertical") * _speed * Time.deltaTime;
        transform.Translate(horizontal, 0f, vertical);
        PlayAnimation(horizontal, vertical);
    }

    private void PlayAnimation(float horizontal, float vertical)
    {
        var inputHorizontal = !Mathf.Approximately(horizontal, 0f);
        var inputVertical = !Mathf.Approximately(vertical, 0f);
        var isMove = inputHorizontal || inputVertical;
        _animator.SetBool("IsWalking", isMove);
    }
}