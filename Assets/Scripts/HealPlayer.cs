using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealPlayer : MonoBehaviour
{
    public List<GameObject> hearts;

    void Update()
    {
        for (int i = 0; i < hearts.Count; i++)
        {
            hearts[i].SetActive(i < PlayerController.Instance.heal);
        }
    }
}
