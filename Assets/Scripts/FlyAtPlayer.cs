using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    public Transform player;
    Vector3 playerPos;
    public float ballSp = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerPos = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPos, ballSp * Time.deltaTime);
    }
}
