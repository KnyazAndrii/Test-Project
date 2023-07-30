using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerSwitch : MonoBehaviour
{
    private string _enterLayer = "NoCollisions";
    private string _exitLayer = "Default";

    private void OnTriggerEnter(Collider other)
    {
        //change static
        other.gameObject.layer = LayerMask.NameToLayer(_enterLayer);
    }
    
    private void OnTriggerExit(Collider other)
    {
        other.gameObject.layer = LayerMask.NameToLayer(_exitLayer);
    }
}
