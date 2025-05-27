using UnityEngine;

public class ScrollCemetery : MonoBehaviour
{
    GameManager gameManager;
    float ppu = 68.0f;  // «»ºø/¿Ø¥÷
    int imgWidth = 1024; // ¿ÃπÃ¡ˆ «»ºø
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
        if (xpos < -imgUnit)
        {
            transform.Translate(imgUnit * 2.0f, 0.0f, 0.0f);
        }
    }
}
