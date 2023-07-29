using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSize : MonoBehaviour
{
    [SerializeField] private PointBar _pointBar;
    [SerializeField] private CinemachineVirtualCamera _cinemachineVirtualCamera;

    private float _scaleStep = 2;
    private float _scaleIncreaseThreshould = 2;
    private float _pointsForScale;
    private float _totalPoints;

    private Vector3 _scales;

    private void Start()
    {
        _scales = gameObject.transform.localScale;

        var transposer = _cinemachineVirtualCamera.GetCinemachineComponent<CinemachineTransposer>();
    }

    private void IncreaseScale()
    {
        _scales.x += _scaleStep;
        _scales.z += _scaleStep;

        transform.localScale = _scales;

        _cinemachineVirtualCamera.GetCinemachineComponent<CinemachineTransposer>().m_FollowOffset.y *= 1.5f;
        _cinemachineVirtualCamera.GetCinemachineComponent<CinemachineTransposer>().m_FollowOffset.z *= 1.5f;
    }

    public void CollectibleCollected(float objectPoints)
    {
        _pointsForScale += objectPoints;
        _totalPoints += objectPoints;

        _pointBar.UpdatePoints(_totalPoints);

        if (_pointsForScale >= _scaleIncreaseThreshould)
        {
            IncreaseScale();

            _pointsForScale = _pointsForScale % _scaleIncreaseThreshould;
        }
    }
}
