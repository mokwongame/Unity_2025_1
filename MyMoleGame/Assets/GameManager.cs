using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement; // TextMeshPro�� ����(using: C ����� #include) ���� ����
public class GameManager : MonoBehaviour
{
    // �뷱�� Ư�� ����
    public float axisSpeed = 15.0f;
    int score = 0;  // �� ����
    public TMP_Text textScore;

    // ȿ���� ����: AudioSource, AudioClip �ʿ�
    public AudioSource audioSource;
    public AudioClip clipBreak;
    public AudioClip voiceStart;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() // ���� ���� ������ ��(Start) �� �ѹ��� ȣ��Ǵ� �Լ�
    {
        updateScore();
        playVoiceStart(); // ������ ���ʷ� ������ ��(Start) ����
    }

    // Update is called once per frame
    void Update()
    {
        // ����ڰ� Escape Ű�� ������(if) ���� ������ ����
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // EndGame �ҷ�����(load)
            SceneManager.LoadScene("EndScene");
        }
    }

    public int getScore() { return score; }
    public void incScore() { score++; updateScore(); } // ���� ����
    public void decScore() { score--; updateScore(); } // ���� ����

    public void updateScore()
    {
        // TMP_Text ����: text ����� ���ڿ� �Ҵ�
        textScore.text = $"Score: {score}";
    }

    public void playBreak()
    {
        audioSource.PlayOneShot(clipBreak, 1.0f); // ���� 100%�� clipBreak ȿ������ �� ����(one shot) ����(play)
    }

    public void playVoiceStart()
    {
        audioSource.PlayOneShot(voiceStart, 0.9f); // ������ 90%�� ����
    }
}
