using UnityEngine;

public class CheckHammer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // �浹(collision)�� ����(enter)�� ��(on) ȣ���ϴ� �޼ҵ�
    private void OnCollisionEnter(Collision collision)
    {
        // tag(����ǥ)�� ����ؼ� �浹 ���ü(collision.gameObject)�� ���� ������Ʈ�� Ȯ��
        // tag�� ������ Unity Editor���� tag�� ��� �ʿ�
        string tag = collision.gameObject.tag;
        Debug.Log($"tag = {tag}");
    }
}
