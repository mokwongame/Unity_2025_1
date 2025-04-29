using UnityEngine;

public class GameManager : MonoBehaviour
{
    // ¹ë·±½Ì Æ¯¼º º¯¼ö
    public float axisSpeed = 15.0f;
    int score = 0;  // ÃÑ µæÁ¡

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public int getScore() { return score; }
    public void incScore() { score++; } // µæÁ¡ Áõ°¡
    public void decScore() { score--; } // µæÁ¡ °¨¼Ò
}
