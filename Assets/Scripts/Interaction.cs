using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    [SerializeField] private GameObject[] _enemies;
    [SerializeField] private GameResults _gameResults;

    private void Start()
    {
        _enemies = GameObject.FindGameObjectsWithTag("Enemy");
    }

    private void Update()
    {
        foreach (var enemy in _enemies)
        {
            if (enemy == null)
                continue;

            if (Vector3.Distance(gameObject.transform.position, enemy.gameObject.transform.position) < 0.2f)
            {
                Destroy(enemy);
                _gameResults.CheakEnemys();
            }
        }
    }
}
