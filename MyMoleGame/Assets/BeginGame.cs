using UnityEngine;
using UnityEngine.SceneManagement;

public class BeginGame : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("beginGame", 5.0f); // 5�� �ڿ� beginGame�� �̸��� �Լ��� ȣ��(invoke)
    }

    // Update is called once per frame
    void Update()
    {

    }

    void beginGame()
    {
        SceneManager.LoadScene("MoleScene"); // ���ο� ���� �ε�
    }
}
