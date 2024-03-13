using UnityEngine;

public class RotateAround : MonoBehaviour
{
    [SerializeField] float _speed = 50;
    [SerializeField] private Transform _rotationCenter;

    private void Update()
    {
        transform.RotateAround(_rotationCenter.position, Vector3.up, _speed * Time.deltaTime);
    }
}
