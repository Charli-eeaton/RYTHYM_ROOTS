using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    public AudioSource missSFX;

    public TMPro.TextMeshPro scoreText;
    public TMPro.TextMeshPro lifeText;

    static int comboScore;
    static int lifeScore = 50;

    void Start()
    {
        Instance = this;
        comboScore = 0;
        lifeScore = 50;
    }
    public static void Hit()
    {
        comboScore += 1;
        lifeScore += 1;
    }
    public static void Miss()
    {
        comboScore = 1;
        lifeScore -= 2;

        if (lifeScore < 0)
        {
            lifeScore = 0;
            SceneManager.LoadScene(3);

        }

        Instance.missSFX.Play();
    }
    private void Update()
    {
        scoreText.text = comboScore.ToString();
        lifeText.text = lifeScore.ToString();
    }
}
