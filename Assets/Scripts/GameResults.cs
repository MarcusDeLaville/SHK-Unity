using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameResults : MonoBehaviour
{
    [SerializeField] private GameObject _endPanel;
    [SerializeField] private GameObject[] _enemies;

    private void Start()
    {
        CheakEnemys();
    }

    public void CheakEnemys()
    {
        _enemies = GameObject.FindGameObjectsWithTag("Enemy");

        if(_enemies.Length == 1)
        {
            _endPanel.SetActive(true);
        }
    }
}
