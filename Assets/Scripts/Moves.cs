using UnityEngine;
public class Moves : MonoBehaviour
{

    [SerializeField] float moveSpeed = 0f;
    public Rigidbody playerRb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() 
    { 

    }

    // Update is called once per frame
    void FixedUpdate()
    {
         
        if (Input.GetKey("d"))
        {
            //VelocityChange, Forcemode is for changing directions easier.
            playerRb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            playerRb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("w"))
        {
            //VelocityChange, Forcemode is for changing directions easier.
            playerRb.AddForce(0, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey("s"))
        {
            playerRb.AddForce(0, 0, -forwardForce * Time.deltaTime, ForceMode.VelocityChange);
        }
    }
}