using UnityEngine;

public class MoveAxisZ : MonoBehaviour
{
    public float zmin = -10.0f;
    public float zmax = 10.0f;
    float speed = 0.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameManager gameManger = FindAnyObjectByType<GameManager>();
        speed = gameManger.axisSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        float zoff = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float zpos = transform.position.z + zoff;
        if (zpos >= zmin && zpos <= zmax)
            transform.Translate(0.0f, 0.0f, zoff);
    }
}
