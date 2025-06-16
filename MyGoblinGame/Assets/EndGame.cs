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
        if (Input.GetKeyDown(KeyCode.X))
        {
            Debug.Log("exit");
            Application.Quit(); // ���� ���� ����
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("GoblinScene");
        }
    }
}
