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
        int num = Random.Range(0, 3); // 0~(3-1)���� ���� ���� �߻�; 0, 1, 2
        if (num == 0) // ���� ��� ����
            Instantiate(goblin, transform.position, transform.rotation);
    }
}
