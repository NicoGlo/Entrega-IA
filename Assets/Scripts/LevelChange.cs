using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChange : MonoBehaviour
{
    public string levelchange;

    private void OnTriggerEnter(Collider other)
    {
        PlayerController detectedPlayer = other.GetComponent<PlayerController>();
        if (detectedPlayer != null)
        {
            SceneManager.LoadScene("Victory");
        }
    }
}
