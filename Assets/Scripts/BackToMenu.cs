using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    public float timeleft = 10f;
    void Update()
    {
        timeleft -= Time.deltaTime;
        if(timeleft <= 0f)
        {
            SceneManager.LoadScene("Menu");
        }

    }
}
