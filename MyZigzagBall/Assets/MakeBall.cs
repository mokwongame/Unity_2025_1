using UnityEngine;

public class MakeBall : MonoBehaviour
{
    // public �ǹ�: Unity Editor���� ball ������ ������ �� �ֵ��� ����ȭ ����
    public GameObject ball; // ���� ����: �������� ������;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // C# Script�� ����Ǹ� �ٷ� ���� ����
        //makeBall();
        //Invoke("makeBall", 3.0f);
        // 3�� �ڿ� makeBall() ȣ���ϰ� 5�� �ֱ�� ��� makeBall() ȣ��
        InvokeRepeating("makeBall", 3.0f, 5.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void makeBall()
    {
        // �ν��Ͻ�(instance, ����) �����
        //Instantiate(ball); // �������� ��ġ���� ����
        Instantiate(ball, transform.position, transform.rotation); // ball�̶� ���� ������Ʈ�� ������� ����(�ν��Ͻ�)�ϱ�
        // empty game object���� ������ ��ġ���� ����
    }
}
