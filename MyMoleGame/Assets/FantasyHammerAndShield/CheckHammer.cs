using UnityEngine;

public class CheckHammer : MonoBehaviour
{
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

    // 충돌(collision)에 진입(enter)할 때(on) 호출하는 메소드
    private void OnCollisionEnter(Collision collision)
    {
        // tag(꼬리표)를 사용해서 충돌 대상체(collision.gameObject)의 게임 오브젝트를 확인
        // tag를 쓰려면 Unity Editor에서 tag를 등록 필요
        string tag = collision.gameObject.tag;
        Debug.Log($"tag = {tag}");
        if (tag == "Mole") // 망치가 두더지와 충돌하면
        {
            gameManager.incScore(); // 점수 증가
            Destroy(gameObject, 0.25f); // 0.25초 후에 망치(gameObject) 파괴
            Destroy(collision.gameObject, 0.5f); // 0.5초 후에 두더지(collision.gameObject) 파괴
            Debug.Log($"score = {gameManager.getScore()}");
        }
        else if (tag == "Plane") // 망치가 지면과 충돌하면
        {
            gameManager.decScore(); // 점수 감소
            Destroy(gameObject, 0.25f);
            Debug.Log($"score = {gameManager.getScore()}");
        }
    }
}
