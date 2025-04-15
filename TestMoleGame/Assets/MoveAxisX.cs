using System.Xml.Serialization;
using UnityEngine;

public class MoveAxisX : MonoBehaviour
{
    public float xmin = -10.0f;
    public float xmax = 10.0f;
    private float speed = 0.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameManager gameManager = FindAnyObjectByType<GameManager>();
        speed = gameManager.axisSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        float xoff = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float xpos = transform.position.x + xoff; // ´ÙÀ½¹ø x ÁÂÇ¥
        if (xpos >= xmin && xpos <= xmax)
            transform.Translate(xoff, 0.0f, 0.0f);
    }
}
