using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.position = Vector3.Lerp(transform.position, _target.position, _speed * Time.deltaTime);
        transform.LookAt(_target);
    }

    public void SetTarget(Transform target)
    {
        _target = target;
    }
}
