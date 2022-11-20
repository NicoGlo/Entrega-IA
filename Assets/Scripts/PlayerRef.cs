using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRef : MonoBehaviour
{
    public GameObject player;
    private void Start()
    {
        player = FindObjectOfType<PlayerController>().gameObject;
    }

}
