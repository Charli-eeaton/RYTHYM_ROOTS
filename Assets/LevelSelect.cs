using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public void Tutorial()
    {
        SceneManager.LoadScene(5);
    }

    public void Spring()
    {
        SceneManager.LoadScene(2);
    }

    public void Summer()
    {
        SceneManager.LoadScene(6);
    }

    public void Autumn()
    {
        SceneManager.LoadScene(7);
    }

    public void Winter()
    {
        SceneManager.LoadScene(8);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(1);
    }
}
