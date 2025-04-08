using UnityEngine;

public class MoveCube : MonoBehaviour
{
    // �ӵ� ���� -> ���� ����
    // ������ �ð��� �ٲ� �ӵ��� �����ϵ��� �ӵ��� ����� ����
    public float speed = 10.0f; // ���ڵ� f �ǹ�: �� ������ �ڷ����� float
    // ������ �Ÿ� = speed*�����ӽð�(������ ������ �ð� ����)
    // public: �ܺ�(Unity Editor)���� ���� ���� ����

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Ű���� ȭ��ǥ �Է�: Input Ŭ����(����, �Լ��� ����ü) ���
        // deltaTime: ������ ������ �ð�(time) ����(delta)
        // Ű���� �ӵ�(���� �ð�): Input.GetAxis()
        // ������: Horizontal axis = <-,a(-); ->,d(+)
        // ������: Vertical axis = ^|,w(+); v|,s(-)
        // xoff = Ű����ӵ�*�ӵ�*�����ӽð�
        float xoff = Input.GetAxis("Horizontal") *speed*Time.deltaTime;
        float zoff = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        // ���� ������Ʈ gameObject�� ��ȯ�� transform
        // transform.Translate(): ���� � ó��
        transform.Translate(xoff, 0.0f, zoff);
    }
}
