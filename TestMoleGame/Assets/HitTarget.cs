using UnityEngine;

public class HitTarget : MonoBehaviour
{
    private GameManager gameManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        string tag = collision.gameObject.tag;
        //Debug.Log($"{tag} is hit.");
        if (tag == "Mole")
        {
            gameManager.playPunch();
            // µÊ¡°
            Debug.Log("We got one point.");
            gameManager.incScore();
            Debug.Log($"score = {gameManager.score}");
            Destroy(gameObject, 0.2f);
            Destroy(collision.gameObject, 0.5f);
        }
        else if (tag == "Plane")
        {
            gameManager.playFail();
            // ∞®¡°
            Debug.Log("We lost one point.");
            gameManager.decScore();
            Debug.Log($"score = {gameManager.score}");
            Destroy(gameObject, 0.2f);
        }
    }
}
