using UnityEngine;

public class MakeGoblin : MonoBehaviour
{
    public GameObject goblin;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("makeGoblin", 1.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void makeGoblin()
    {
        Instantiate(goblin, transform.position, transform.rotation);
    }
}
