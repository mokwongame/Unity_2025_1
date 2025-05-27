using UnityEngine;

public class ScrollCemetery : MonoBehaviour
{
    GameManager gameManager;
    float ppu = 40;
    int imgWidth = 600;
    float imgUnit;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
        imgUnit = imgWidth / ppu;
    }

    // Update is called once per frame
    void Update()
    {
        float xoff = -gameManager.speedBack * Time.deltaTime;
        transform.Translate(xoff, 0.0f, 0.0f);
        float xpos = transform.position.x;
        if (xpos <= -imgUnit)
        {
            transform.Translate(2.0f * imgUnit, 0.0f, 0.0f);
        }
    }
}
