using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public float axisSpeed = 10.0f;
    public int score = 0;
    public TMP_Text textScore;
    public AudioClip clipFail;
    public AudioClip clipPunch;
    public AudioClip clipStart;
    public AudioSource audioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playStart();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void incScore()
    {
        score++;
        textScore.text = $"score = {score}";
    }

    public void decScore()
    {
        score--;
        textScore.text = $"score = {score}";
    }

    public void playPunch()
    {
        float prevVol = audioSource.volume;
        audioSource.volume = 1.0f;
        audioSource.PlayOneShot(clipPunch);
        audioSource.volume = prevVol;
    }

    public void playFail()
    {
        float prevVol = audioSource.volume;
        audioSource.volume = 1.0f;
        audioSource.PlayOneShot(clipFail);
        audioSource.volume = prevVol;
    }

    public void playStart()
    {
        float prevVol = audioSource.volume;
        audioSource.volume = 1.0f;
        audioSource.PlayOneShot(clipStart);
        audioSource.volume = prevVol;
    }
}
