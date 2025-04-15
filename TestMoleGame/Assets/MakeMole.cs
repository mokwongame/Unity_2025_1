using UnityEngine;

public class MakeMole : MonoBehaviour
{
    public GameObject mole;
    public float startTime = 2.0f;
    public float repeatTime = 5.0f;
    public float xmin = -9.0f;
    public float xmax = 9.0f;
    public float zmin = -9.0f;
    public float zmax = 9.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("makeMole", startTime, repeatTime);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void makeMole()
    {
        Vector3 pos = transform.position;
        pos.x = Random.Range(xmin, xmax); // xmin과 xmax 사이에 난수를 발생
        pos.y = -1.5f;
        pos.z = Random.Range(zmin, zmax);
        Instantiate(mole, pos, transform.rotation);
    }
}
