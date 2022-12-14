using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerController detectedPlayer = other.GetComponent<PlayerController>();
        if (detectedPlayer != null)
        {
            SceneManager.LoadScene("Swamp");
        }
    }
}
