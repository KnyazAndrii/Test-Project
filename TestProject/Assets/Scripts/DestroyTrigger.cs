using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTrigger : MonoBehaviour
{
    [SerializeField] private PlayerSize _playerSize;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Collectible collectible))
        {
            _playerSize.CollectibleCollected(collectible.GetPoints());

            Destroy(other.gameObject);
        }
    }
}
