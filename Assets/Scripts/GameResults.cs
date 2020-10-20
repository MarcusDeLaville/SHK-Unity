using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameResults : MonoBehaviour
{
    [SerializeField] private GameObject _endPanel;
    [SerializeField] private List<Enemy> _enemies;

    private void OnDie()
    {
        int aliveEnemyCount = _enemies.Count(enemy => enemy.IsAlive == true);

        print(aliveEnemyCount);

        if(aliveEnemyCount == 0)
        {
            _endPanel.SetActive(true);
        }
    }

    private void OnEnable()
    {
        foreach (Enemy enemy in _enemies)
        {
            enemy.Died += OnDie;
        }
    }
}
