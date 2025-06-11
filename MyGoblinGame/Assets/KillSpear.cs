using UnityEngine;

public class KillSpear : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, 4.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
