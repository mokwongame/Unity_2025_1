using UnityEngine;
using UnityEngine.SceneManagement;

public class BeginGame : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("beginGame", 3.0f); // 5초 뒤에 beginGame이 이름인 함수를 호출(invoke)
    }

    // Update is called once per frame
    void Update()
    {

    }

    void beginGame()
    {
        SceneManager.LoadScene("MoleScene"); // 새로운 씬을 로딩
    }
}
