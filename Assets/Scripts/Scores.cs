using UnityEngine;

public class Scores : MonoBehaviour
{
    int hits = 0;
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Hit")
        {
            hits++;
            Debug.Log("Objects you hit:" + hits);
        }
    }
}
