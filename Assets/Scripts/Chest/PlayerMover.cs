using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _rotateSpeed;
    private void Update()
    {
        Move();
        Rotate(); 
    }

    private void Move()
    {
        float direction = Input.GetAxis("Vertical");
        float distance = direction * _moveSpeed * Time.deltaTime;

        transform.Translate(distance * Vector3.forward);
    }

    private void Rotate()
    {
        float rotation = Input.GetAxis("Horizontal");

        transform.Rotate(rotation * _rotateSpeed * Time.deltaTime * Vector3.up);
    }
}
