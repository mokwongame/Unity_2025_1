using UnityEngine;

public class KillHammer : MonoBehaviour
{
    public float killTime = 5.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, killTime);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
