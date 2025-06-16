using UnityEngine;
using UnityEngine.SceneManagement;

public class BeginGame : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("beginGame", 3.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void beginGame()
    {
        SceneManager.LoadScene("GoblinScene");
    }
}
