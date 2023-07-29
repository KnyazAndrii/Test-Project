using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private FixedJoystick _joystick;

    private float _moveSpeed = 0.1f;

    private void FixedUpdate()
    {
        gameObject.transform.position = new Vector3(transform.position.x - _joystick.Horizontal * _moveSpeed, transform.position.y, transform.position.z - _joystick.Vertical * _moveSpeed);
    }
}
