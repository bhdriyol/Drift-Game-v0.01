using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene("Scene1");
    }

    public void OptionsButton()
    {
        Debug.Log("Options");
    }
}
