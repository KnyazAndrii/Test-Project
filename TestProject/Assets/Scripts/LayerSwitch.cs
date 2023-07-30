using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class LayerSwitch : MonoBehaviour
{
    private string _enterLayer = "NoCollisions";
    private string _exitLayer = "Default";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Human"))
        {
            other.GetComponent<NavMeshAgent>().enabled = false;
        }
        other.gameObject.layer = LayerMask.NameToLayer(_enterLayer);
    }
    
    private void OnTriggerExit(Collider other)
    {
        other.gameObject.layer = LayerMask.NameToLayer(_exitLayer);
    }
}
