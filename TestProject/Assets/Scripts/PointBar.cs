using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointBar : MonoBehaviour
{
    void Update()
    {
        transform.LookAt(transform.position + Camera.main.transform.forward);
    }
}
