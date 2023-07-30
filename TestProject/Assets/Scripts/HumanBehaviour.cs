using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class HumanBehaviour : MonoBehaviour
{
    private NavMeshAgent _navMeshAgent;
    private Animator _animator;
    private Vector3 _spawnPoint;
    public Vector3 _newPoint;
    private float _distance = 20;
    private float _seconds = 15;

    private void Start()
    {
        _spawnPoint = transform.position;
        _animator = GetComponent<Animator>();

        _navMeshAgent = GetComponentInChildren<NavMeshAgent>();

        StartCoroutine("NewPointTimer");
    }

    private void Update()
    {
        if (transform.position.x == _newPoint.x && transform.position.z == _newPoint.z)
        {
            _animator.Play("Idle");
        }
    }

    public IEnumerator NewPointTimer()
    {
        _newPoint = _spawnPoint;
        _newPoint.x += Random.Range(-_distance, _distance);
        _newPoint.z += Random.Range(-_distance, _distance);
        _navMeshAgent.SetDestination(_newPoint);
        _animator.Play("RunForward");

        yield return new WaitForSeconds(_seconds);
        StartCoroutine("NewPointTimer");
    }
}
