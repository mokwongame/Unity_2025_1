using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("MoleScene");
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            Application.Quit(); // 게임을 실행하는 애플리케이션(앱)을 종료
            Debug.Log("game quit.");
        }
    }
}
