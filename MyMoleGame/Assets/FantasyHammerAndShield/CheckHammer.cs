using UnityEngine;

public class CheckHammer : MonoBehaviour
{
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

    // �浹(collision)�� ����(enter)�� ��(on) ȣ���ϴ� �޼ҵ�
    private void OnCollisionEnter(Collision collision)
    {
        // tag(����ǥ)�� ����ؼ� �浹 ���ü(collision.gameObject)�� ���� ������Ʈ�� Ȯ��
        // tag�� ������ Unity Editor���� tag�� ��� �ʿ�
        string tag = collision.gameObject.tag;
        Debug.Log($"tag = {tag}");
        if (tag == "Mole") // ��ġ�� �δ����� �浹�ϸ�
        {
            gameManager.incScore(); // ���� ����
            Destroy(gameObject, 0.25f); // 0.25�� �Ŀ� ��ġ(gameObject) �ı�
            Destroy(collision.gameObject, 0.5f); // 0.5�� �Ŀ� �δ���(collision.gameObject) �ı�
            Debug.Log($"score = {gameManager.getScore()}");
        }
        else if (tag == "Plane") // ��ġ�� ����� �浹�ϸ�
        {
            gameManager.decScore(); // ���� ����
            Destroy(gameObject, 0.25f);
            Debug.Log($"score = {gameManager.getScore()}");
        }
    }
}
