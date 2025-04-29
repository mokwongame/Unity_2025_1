using UnityEngine;

public class KillHammer : MonoBehaviour
{
    public float killTime = 10.0f; // killTime 초 후에 게임 오브젝트 파괴
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, killTime); // killTime 초 후에 현재 게임 오브젝트(gameObject) 파괴
    }

    // Update is called once per frame
    void Update()
    {

    }
}
