using UnityEngine;

public class KillHammer : MonoBehaviour
{
    public float killTime = 10.0f; // killTime �� �Ŀ� ���� ������Ʈ �ı�
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, killTime); // killTime �� �Ŀ� ���� ���� ������Ʈ(gameObject) �ı�
    }

    // Update is called once per frame
    void Update()
    {

    }
}
