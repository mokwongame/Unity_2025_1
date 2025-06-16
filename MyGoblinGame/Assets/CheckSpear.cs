using UnityEngine;

public class CheckSpear : MonoBehaviour
{
    public GameObject bang;

    GameManager gameManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    // 충돌(collision)이 시작(enter)되면(on) 호출되는 이벤트 핸들러
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // 충돌된 상대방 게임 오브젝트의 정보는 collision에 저장
        string tag = collision.gameObject.tag;
        if (tag == "Goblin") // 창이 고블린에 충돌
        {
            makeBang();
            gameManager.incScore(gameManager.scoreGoblin);
            Destroy(collision.gameObject, 0.25f);    // 0.5초 뒤에 고블린 파괴
            Destroy(gameObject, 0.5f); // 0.25초 뒤에 창을 파괴
        }
    }

    void makeBang()
    {
        Vector3 pos = transform.position;
        pos.x += 1.5f;
        Instantiate(bang, pos, transform.rotation);
    }
}
