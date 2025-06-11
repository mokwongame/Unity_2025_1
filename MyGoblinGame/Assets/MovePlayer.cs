using System;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public GameObject spear;

    GameManager gameManager;
    float xmin = -6.0f;
    float xmax = 6.0f;
    float ymin = -4.1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        float xoff = Input.GetAxis("Horizontal") * gameManager.speedPlayer * Time.deltaTime;
        float xpos = transform.position.x + xoff;
        if (xpos >= xmin && xpos <= xmax) // xÆÇ ¿Ãµø π¸¿ß ¡¶«—
            transform.Translate(xoff, 0.0f, 0.0f);
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
        pos.x += 3.0f;

        GameObject newSpear = Instantiate(spear, pos, spear.transform.rotation);
        Rigidbody2D rb = newSpear.GetComponent<Rigidbody2D>();
        rb.AddForce(Vector2.right * gameManager.forceSpear);
    }

    private void jumpPlayer()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.AddForce(Vector2.up * gameManager.forcePlayer); // AddForce(): ∆Ø¡§ πÊ«‚¿∏∑Œ »˚¡÷±‚
    }
}
