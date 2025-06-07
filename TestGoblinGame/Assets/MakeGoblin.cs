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
        int ran = Random.Range(0, 3); // 0, 1, 2중의 하나가 난수로 발생함; 3은 나오지 않음
        if (ran == 0) // 고블린 생성
        {
            Instantiate(goblin, transform.position, transform.rotation);
        }
    }
}
