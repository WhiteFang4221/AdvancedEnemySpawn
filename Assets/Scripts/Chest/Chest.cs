using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    private readonly int OpenTrigger = Animator.StringToHash("OpenTrigger");

    [SerializeField] private Animator _animator;

    public void Open()
    {
        _animator.SetTrigger(OpenTrigger);
    }
}
