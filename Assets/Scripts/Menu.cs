using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void NewGameClick()
    {
        SceneManager.LoadScene("Swamp");
    }

    public void ExitClick()
    {
        Application.Quit();
    }
}
