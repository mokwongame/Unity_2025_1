using UnityEngine;
using TMPro; // TextMeshPro를 쓰기(using: C 언어의 #include) 위한 선언
public class GameManager : MonoBehaviour
{
    // 밸런싱 특성 변수
    public float axisSpeed = 15.0f;
    int score = 0;  // 총 득점
    public TMP_Text textScore;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        updateScore();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public int getScore() { return score; }
    public void incScore() { score++; updateScore(); } // 득점 증가
    public void decScore() { score--; updateScore(); } // 득점 감소

    public void updateScore()
    {
        // TMP_Text 갱신: text 멤버에 문자열 할당
        textScore.text = $"Score: {score}";
    }
}
