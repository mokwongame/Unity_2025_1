using UnityEngine;

public class GameManager : MonoBehaviour
{
    // �뷱�� Ư�� ����
    public float axisSpeed = 15.0f;
    int score = 0;  // �� ����

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public int getScore() { return score; }
    public void incScore() { score++; } // ���� ����
    public void decScore() { score--; } // ���� ����
}
