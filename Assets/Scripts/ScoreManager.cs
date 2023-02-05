using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    public AudioSource missSFX;

    public TMPro.TextMeshPro comboText;
    public TMPro.TextMeshPro lifeText;
    public TMPro.TextMeshPro scoreText;

    static int score;
    static int comboScore;
    static int lifeScore = 50;

    void Start()
    {
        Instance = this;
        comboScore = 0;
        lifeScore = 5000;
    }
    public static void Hit()
    {
        comboScore += 1;
        lifeScore += 1;   
        score += 100;
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
        comboText.text = comboScore.ToString();
        lifeText.text = lifeScore.ToString();
        scoreText.text = score.ToString();
    }
}
