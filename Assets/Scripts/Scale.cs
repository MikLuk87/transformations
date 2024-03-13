
using System;
using UnityEngine;

public class Scale : MonoBehaviour
{
    private Vector3 _scale;

    private float _counter;
    [SerializeField] private float _scaleSpeed = 0.001f;
    [SerializeField] private float _scaleLevel = 0.5f;
    [SerializeField] private float _manualScale = 1.5f;

    private void Update()
    {
        _counter += _scaleSpeed;

        _scale.x = Convert.ToSingle(_scaleLevel * Math.Sin(_counter) + _manualScale);
        _scale.y = Convert.ToSingle(_scaleLevel * Math.Sin(_counter) + _manualScale);
        _scale.z = Convert.ToSingle(_scaleLevel * Math.Sin(_counter) + _manualScale);

        transform.localScale = _scale;
    }
}
