using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSize : MonoBehaviour
{
    [SerializeField] private PointBar _pointBar;
    [SerializeField] private CinemachineVirtualCamera _cinemachineVirtualCamera;

    private float _scaleStep = 4;
    [SerializeField] private float _totalPoints;
    private const float _firstStepForIncrease = 20;
    private bool _firstStepIncrease = false;
    private const float _secondStepForIncrease = 50;
    private bool _secondStepIncrease = false;
    private const float _thirdStepForIncrease = 100;
    private bool _thirdStepIncrease = false;
    private const float _fourthStepForIncrease = 300;
    private bool _fourthStepIncrease = false;
    private const float _pointsToWin = 600;

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

        _cinemachineVirtualCamera.GetCinemachineComponent<CinemachineTransposer>().m_FollowOffset.y *= 2f;
        _cinemachineVirtualCamera.GetCinemachineComponent<CinemachineTransposer>().m_FollowOffset.z *= 2f;
    }

    public void CollectibleCollected(float objectPoints)
    {
        _totalPoints += objectPoints;

        _pointBar.UpdatePoints(_totalPoints);

        switch (_totalPoints)
        { 
            case >= _pointsToWin:
                //win;
                break;

            case >= _fourthStepForIncrease:
                if (_fourthStepIncrease)
                {
                    IncreaseScale();
                }
                _fourthStepIncrease = true;
                break;

            case >= _thirdStepForIncrease:
                if (!_thirdStepIncrease)
                { 
                    IncreaseScale();
                }
                _thirdStepIncrease = true;
                break;

            case >= _secondStepForIncrease:
                if (!_secondStepIncrease)
                {
                    IncreaseScale();
                }
                _secondStepIncrease = true;
                break;

            case >= _firstStepForIncrease:
                if (!_firstStepIncrease)
                {
                    IncreaseScale();
                }
                _firstStepIncrease = true;
                break;

            default:
                Debug.Log("Not enough points");
                break;
        }
    }
}
