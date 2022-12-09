using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

[CreateAssetMenu(fileName = "Text", menuName = "ScriptableObjects/States/Text")]
public class StateText : MonoBehaviour
{
    public TMPro.TMP_Text text;
    public GameObject canvas;
    public void Start()
    {
        canvas = FindObjectOfType<Bear>().gameObject;

    }
}
