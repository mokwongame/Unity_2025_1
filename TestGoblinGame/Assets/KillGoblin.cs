using UnityEngine;

public class KillGoblin : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        if (pos.y <= -10.0f)
            Destroy(gameObject);
    }
}
