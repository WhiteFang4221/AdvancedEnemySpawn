using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Looking : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform _camera;
    [SerializeField] private Transform _body;

    private void Update()
    {
        _camera.Rotate(-Input.GetAxis("Mouse Y") * Time.deltaTime * Vector3.right * _speed);
        _body.Rotate(Input.GetAxis("Mouse X") * Time.deltaTime * Vector3.up * _speed);
    }
}
