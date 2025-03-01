using UnityEngine;

public class Dropper : MonoBehaviour
{

    public float timeToWait = 3f;
    MeshRenderer dropperMR;
    Rigidbody dropperRB;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dropperMR = GetComponent<MeshRenderer>();
        dropperRB = GetComponent<Rigidbody>();
        dropperMR.enabled = false;
        dropperRB.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Time.time is time spent in the game
        if (Time.time > timeToWait)
        {
            dropperMR.enabled = true;
            dropperRB.useGravity = true;
        }
    }
}
