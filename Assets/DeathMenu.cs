using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    public void Retry()
    {
        SceneManager.LoadScene(3);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
