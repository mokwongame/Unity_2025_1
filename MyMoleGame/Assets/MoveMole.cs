using UnityEngine;

public class MoveMole : MonoBehaviour
{
    public float ymin = -2.0f;
    public float ymax = 2.0f;
    public float speed = 1.0f;
    public float ypos = 0.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ypos = ymin;
    }

    // Update is called once per frame
    void Update()
    {
        ypos += speed * Time.deltaTime;
        if (ypos > ymax)
        {
            speed = -speed;
        }
        else if (ypos < ymin)
        {
            Destroy(gameObject);
        }
        Vector3 pos = transform.position;
        pos.y = ypos;
        transform.position = pos;
    }
}
