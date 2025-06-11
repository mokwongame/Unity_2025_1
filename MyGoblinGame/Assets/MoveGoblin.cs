using UnityEngine;

public class MoveGoblin : MonoBehaviour
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
        float xoff = -gameManager.speedGoblin * Time.deltaTime;
        transform.Translate(xoff, 0.0f, 0.0f);
    }
}
