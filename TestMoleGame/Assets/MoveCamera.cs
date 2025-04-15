using Unity.VisualScripting;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public float rotSpeed = 500.0f;
    public GameObject plane;
    bool prevClick = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (prevClick && Input.GetAxis("Fire1") != 0.0f) // 마우스 좌클릭
        {
            float angOff = Input.GetAxis("Mouse X") * rotSpeed * Time.deltaTime;
            transform.RotateAround(plane.transform.position, Vector3.up, angOff);
        }
        prevClick = (Input.GetAxis("Fire1") == 0.0f) ? false : true;
    }
}
