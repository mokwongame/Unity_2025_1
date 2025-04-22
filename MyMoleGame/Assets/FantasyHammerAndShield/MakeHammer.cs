using UnityEngine;

public class MakeHammer : MonoBehaviour
{
    public GameObject hammer;
    private GameObject axisX, axisZ; // private은 안써도 됨; 쓰면 명확해짐

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
        //Vector3 pos = transform.position; // 빈 게임 오브젝트의 위치(position) 가져오기
        Vector3 pos = hammer.transform.position; // 게임 오브젝트 hammer의 위치(position) 가져오기
        pos.x = axisX.transform.position.x;
        pos.z = axisZ.transform.position.z;
        Instantiate(hammer, pos, hammer.transform.rotation);
    }
}
