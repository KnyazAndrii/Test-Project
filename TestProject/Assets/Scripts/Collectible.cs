using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    [SerializeField] private float points;
    
    public float GetPoints()
    {
        return points;
    }
}
