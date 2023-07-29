using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSize : MonoBehaviour
{
    [SerializeField] private float _scaleIncreaseThreshould;
    [SerializeField] private float _scaleStep;
    private float _scaleValue;

    private void IncreaseScale()
    {
        transform.localScale += _scaleStep * Vector3.one;
    }

    public void CollectibleCollected(float objectSize)
    {
        _scaleValue += objectSize;

        if (_scaleValue >= _scaleIncreaseThreshould)
        {
            IncreaseScale();

            _scaleValue = _scaleValue % _scaleIncreaseThreshould;
        }
    }
}
