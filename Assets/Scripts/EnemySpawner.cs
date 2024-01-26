using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    
    [SerializeField] private Enemy _prefab;
    [SerializeField] private float _spawnDelay;
    [SerializeField] private int _npcCount;
    [SerializeField] private Transform _target;


    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        for (int i = 0; i < _npcCount;i++)
        {
            Enemy npc = Instantiate(_prefab, transform.position, Quaternion.identity);
            npc.SetTarget(_target);


            yield return new WaitForSeconds(_spawnDelay);
        }
    }
}
