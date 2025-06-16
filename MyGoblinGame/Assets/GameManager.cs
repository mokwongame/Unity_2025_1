using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public float speedBack = 3.0f;
    public float speedPlayer = 6.0f;
    public float speedGoblin = 3.0f;
    public float forcePlayer = 3000.0f;
    public float forceSpear = 1000.0f;
    public int scoreSpear = 5; // 창은 5점
    public int scoreGoblin = 10; // 고블린은 10점

    public TMP_Text textScore;

    int score = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void incScore(int s)
    {
        score += s;
        updateScore();
    }
    public void decScore(int s)
    {
        score -= s;
        updateScore();
    }

    public void updateScore()
    {
        string sScore = $"Score: {score}";
        textScore.text = sScore;
    }
}
