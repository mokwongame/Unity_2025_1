using UnityEngine;

public class MakeBall : MonoBehaviour
{
    // public 의미: Unity Editor에서 ball 변수에 접근할 수 있도록 공용화 선언
    public GameObject ball; // 변수 선언: 데이터형 변수명;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // C# Script가 실행되면 바로 공이 생성
        //makeBall();
        //Invoke("makeBall", 3.0f);
        // 3초 뒤에 makeBall() 호출하고 5초 주기로 계속 makeBall() 호출
        InvokeRepeating("makeBall", 3.0f, 5.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void makeBall()
    {
        // 인스턴스(instance, 예시) 만들기
        //Instantiate(ball); // 프리팹의 위치에서 생성
        Instantiate(ball, transform.position, transform.rotation); // ball이란 게임 오브젝트를 실행시켜 생성(인스턴스)하기
        // empty game object에서 설정한 위치에서 생성
    }
}
