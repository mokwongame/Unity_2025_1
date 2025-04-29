using UnityEngine;

public class MoveAxisX : MonoBehaviour
{
    public float xmin = -10.0f;
    public float xmax = 10.0f;
    float speed = 0.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // type으로 게임 오브젝트 찾기
        GameManager gameManager = FindAnyObjectByType<GameManager>();
        speed = gameManager.axisSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        float xoff = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float xpos = transform.position.x + xoff; // 다음번 x 좌표
        if (xpos >= xmin && xpos <= xmax)
            transform.Translate(xoff, 0.0f, 0.0f);
    }
}
