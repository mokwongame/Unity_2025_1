using UnityEngine;

public class MakeHammer : MonoBehaviour
{
    public GameObject hammer;
    private GameObject axisX;
    private GameObject axisZ;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        axisX = GameObject.Find("AxisX"); // 이름이 "..."인 게임 오브젝트 찾기
        axisZ = GameObject.Find("AxisZ");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            makeHammer();
        }
    }

    void makeHammer()
    {
        float xpos = axisX.transform.position.x;
        float zpos = axisZ.transform.position.z;
        Vector3 pos = transform.position;
        pos.x = xpos;
        pos.z = zpos;
        Instantiate(hammer, pos, hammer.transform.rotation);
    }
}
