using UnityEngine;

public class MakeHammer : MonoBehaviour
{
    public GameObject hammer;
    private GameObject axisX, axisZ; // private�� �Ƚᵵ ��; ���� ��Ȯ����

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        axisX = GameObject.Find("AxisX");
        axisZ = GameObject.Find("AxisZ");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            makeHammer();
    }

    void makeHammer()
    {
        //Vector3 pos = transform.position; // �� ���� ������Ʈ�� ��ġ(position) ��������
        Vector3 pos = hammer.transform.position; // ���� ������Ʈ hammer�� ��ġ(position) ��������
        pos.x = axisX.transform.position.x;
        pos.z = axisZ.transform.position.z;
        Instantiate(hammer, pos, hammer.transform.rotation);
    }
}
