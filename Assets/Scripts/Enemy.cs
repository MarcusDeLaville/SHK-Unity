using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Enemy : MonoBehaviour
{
    private Vector3 _target;
    private int _radius = 4;
    private int _smooth = 2;

    public UnityAction Died;
    public bool IsAlive { get; private set; } = true;

    private void Start()
    {
        ResetTarget();
    }
    
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target, _smooth * Time.deltaTime);

        if (transform.position == _target)
        {
            ResetTarget();
        }     
    }

    public void Die()
    {
        IsAlive = false;
        gameObject.SetActive(false);
        Died?.Invoke();
    }

    private void ResetTarget()
    {
        _target = Random.insideUnitCircle * _radius;
    }
}
