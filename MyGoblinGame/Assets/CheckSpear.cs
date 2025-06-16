using UnityEngine;

public class CheckSpear : MonoBehaviour
{
    public GameObject bang;

    GameManager gameManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    // �浹(collision)�� ����(enter)�Ǹ�(on) ȣ��Ǵ� �̺�Ʈ �ڵ鷯
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // �浹�� ���� ���� ������Ʈ�� ������ collision�� ����
        string tag = collision.gameObject.tag;
        if (tag == "Goblin") // â�� ����� �浹
        {
            makeBang();
            gameManager.incScore(gameManager.scoreGoblin);
            Destroy(collision.gameObject, 0.25f);    // 0.5�� �ڿ� ��� �ı�
            Destroy(gameObject, 0.5f); // 0.25�� �ڿ� â�� �ı�
        }
    }

    void makeBang()
    {
        Vector3 pos = transform.position;
        pos.x += 1.5f;
        Instantiate(bang, pos, transform.rotation);
    }
}
