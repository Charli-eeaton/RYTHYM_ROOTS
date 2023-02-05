using System.Collections;
using System.Collections.Generic;
//using System.Runtime.Hosting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManu : MonoBehaviour
{
    public void PlayGame ()
    {
        SceneManager.LoadScene("RhythmRoots");
    }
    public void LevelSelect()
    {
        SceneManager.LoadScene("LevelSelect");
    }
    public void Exit()
    {
        Application.Quit();
    }
}
