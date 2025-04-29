using UnityEngine;
using TMPro; // TextMeshPro�� ����(using: C ����� #include) ���� ����
public class GameManager : MonoBehaviour
{
    // �뷱�� Ư�� ����
    public float axisSpeed = 15.0f;
    int score = 0;  // �� ����
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
    public void incScore() { score++; updateScore(); } // ���� ����
    public void decScore() { score--; updateScore(); } // ���� ����

    public void updateScore()
    {
        // TMP_Text ����: text ����� ���ڿ� �Ҵ�
        textScore.text = $"Score: {score}";
    }
}
