using UnityEngine;

public class CheckHammer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

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
    }
}
