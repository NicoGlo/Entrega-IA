using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider collision) 
    {
        PlayerController playercontroller = collision.GetComponent<PlayerController>();
        if (playercontroller != null)
        {
            if (playercontroller.heal <= 0) //si el jugador tiene menos de 0 vidas 
            {
                SceneManager.LoadScene("Menu");
            }
            else
            {
                playercontroller.heal--;
            }

        }
    }
}

