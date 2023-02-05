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
    static int lifeScore = 25;

    void Start()
    {
        Instance = this;
        comboScore = 0;
        lifeScore = 25;
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
        comboText.text = "Combo: " + comboScore.ToString();
        lifeText.text = "Life points: " + lifeScore.ToString();
        scoreText.text = "Score: " + score.ToString();
    }
}
