using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    [SerializeField] private float size;
    
    public float GetSize()
    {
        return size;
    }
}
