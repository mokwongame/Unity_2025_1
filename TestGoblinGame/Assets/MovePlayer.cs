using System;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    GameManager gameManager;
    float xmin = -6.0f;
    float xmax = 6.0f;
    float ymin = -4.4f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // 좌우 이동
        float xoff = Input.GetAxis("Horizontal") * gameManager.speedPlayer * Time.deltaTime;
        float xpos = transform.position.x + xoff;
        if (xpos >= xmin && xpos <= xmax)
            transform.Translate(xoff, 0.0f, 0.0f);
        // 점프
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            float ypos = transform.position.y;
            if (ypos <= ymin) jumpPlayer();
        }
    }

    private void jumpPlayer()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.AddForce(Vector2.up * gameManager.forcePlayer);
    }
}
