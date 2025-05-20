using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement; // TextMeshPro를 쓰기(using: C 언어의 #include) 위한 선언
public class GameManager : MonoBehaviour
{
    // 밸런싱 특성 변수
    public float axisSpeed = 15.0f;
    int score = 0;  // 총 득점
    public TMP_Text textScore;

    // 효과음 생성: AudioSource, AudioClip 필요
    public AudioSource audioSource;
    public AudioClip clipBreak;
    public AudioClip voiceStart;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() // 현재 씬이 시작할 때(Start) 딱 한번만 호출되는 함수
    {
        updateScore();
        playVoiceStart(); // 게임이 최초로 시작할 때(Start) 연주
    }

    // Update is called once per frame
    void Update()
    {
        // 사용자가 Escape 키를 누르면(if) 현재 게임을 종료
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // EndGame 불러오기(load)
            SceneManager.LoadScene("EndScene");
        }
    }

    public int getScore() { return score; }
    public void incScore() { score++; updateScore(); } // 득점 증가
    public void decScore() { score--; updateScore(); } // 득점 감소

    public void updateScore()
    {
        // TMP_Text 갱신: text 멤버에 문자열 할당
        textScore.text = $"Score: {score}";
    }

    public void playBreak()
    {
        audioSource.PlayOneShot(clipBreak, 1.0f); // 볼륨 100%로 clipBreak 효과음을 한 번만(one shot) 연주(play)
    }

    public void playVoiceStart()
    {
        audioSource.PlayOneShot(voiceStart, 0.9f); // 볼륨을 90%로 연주
    }
}
