using UnityEngine;

public class rotating : MonoBehaviour
{
    public float xRotate = 0f;
    public float yRotate = 0f;
    public float zRotate = 0f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xRotate * Time.deltaTime, yRotate * Time.deltaTime, zRotate * Time.deltaTime);
    }
}
