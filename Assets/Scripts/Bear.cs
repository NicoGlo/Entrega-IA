using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bear : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Hunter detectedPlayer = other.GetComponent<Hunter>();
        if (detectedPlayer != null)
        {
            Destroy(this.gameObject);
        }
    }
}
