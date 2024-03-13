using System;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private Vector3 _speed;

    [SerializeField] int _amplitudeReduction = 50;

    [SerializeField] float _acceleration = 0.01f;
    [SerializeField] float _speedValue = 0.01f;

    private void Update()
    {
        _speed.z = Convert.ToSingle(Math.Sin(_speedValue));
        _speed.x = Convert.ToSingle(Math.Sin(_speedValue));

        transform.Translate(_speed / _amplitudeReduction);

        _speedValue += _acceleration;
    }
}
