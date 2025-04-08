using UnityEngine;

public class MoveCube : MonoBehaviour
{
    // 속도 고정 -> 변수 선언
    // 프레임 시간이 바뀌어도 속도가 일정하도록 속도에 상수를 배정
    public float speed = 10.0f; // 숫자뒤 f 의미: 이 숫자의 자료형이 float
    // 움직인 거리 = speed*프레임시간(프레임 사이의 시간 간격)
    // public: 외부(Unity Editor)에서 변수 접근 가능

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 키보드 화살표 입력: Input 클래스(변수, 함수의 집합체) 사용
        // deltaTime: 프레임 사이의 시간(time) 간격(delta)
        // 키도브 속도(지속 시간): Input.GetAxis()
        // 가로축: Horizontal axis = <-,a(-); ->,d(+)
        // 세로축: Vertical axis = ^|,w(+); v|,s(-)
        // xoff = 키보드속도*속도*프레임시간
        float xoff = Input.GetAxis("Horizontal") *speed*Time.deltaTime;
        float zoff = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        // 게임 오브젝트 gameObject의 변환은 transform
        // transform.Translate(): 병진 운동 처리
        transform.Translate(xoff, 0.0f, zoff);
    }
}
