using System;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public GameObject spear;

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
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            makeSpear();
        }
    }

    private void makeSpear()
    {
        Vector3 pos = transform.position;
        pos.x += 2.0f;
        GameObject newSpear = Instantiate(spear, pos, spear.transform.rotation); // spear는 프리팹
        Rigidbody2D rb = newSpear.GetComponent<Rigidbody2D>();
        rb.AddForce(Vector2.right * gameManager.forceSpear);
    }

    private void jumpPlayer()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.AddForce(Vector2.up * gameManager.forcePlayer);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        string tag = collision.gameObject.tag;
        if (tag == "Goblin")
        {
            Destroy(gameObject, 0.25f);
            Debug.Log("Knight is hit.");
            // 게임 종료
        }
    }
}
