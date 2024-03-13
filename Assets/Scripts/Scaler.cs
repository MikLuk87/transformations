using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed = 0.01f;

    private Vector3 _scale;

    private void Update()
    {
        _scale.x += _scaleSpeed;
        _scale.y += _scaleSpeed;
        _scale.z += _scaleSpeed;

        transform.localScale = _scale;
    }
}
