using System.Xml.Serialization;
using UnityEngine;

public class MakeMole : MonoBehaviour
{
    public GameObject mole;
    public float startTime = 1.0f;
    public float repeatTime = 4.0f;
    public float xmin = -8.0f;
    public float xmax = 8.0f;
    public float zmin = -8.0f;
    public float zmax = 8.0f;

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
        float xpos = Random.Range(xmin, xmax); // xmin�� xmax ������ ����(range)���� ����(random number)�� ����
        float zpos = Random.Range(zmin, zmax);
        Vector3 pos = transform.position; // x, y, z�� ���� ����
        pos.x = xpos;
        pos.z = zpos;
        Instantiate(mole, pos, transform.rotation);
    }
}
