using UnityEngine;

public class CheckSpear : MonoBehaviour
{
    public GameObject bang;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        string tag = collision.gameObject.tag;
        if (tag == "Goblin")
        {
            makeBang();
            Destroy(collision.gameObject, 0.25f); // °íºí¸°À» ÆÄ±«
            Destroy(gameObject, 0.5f); // spear(Ã¢)À» ÆÄ±«
            Debug.Log("Goblin is shot.");
        }
    }

    void makeBang()
    {
        Vector3 pos = transform.position;
        pos.x += 1.5f;
        Instantiate(bang, pos, transform.rotation);
    }
}
