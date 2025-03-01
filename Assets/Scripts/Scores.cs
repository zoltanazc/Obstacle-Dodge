using UnityEngine;

public class Scores : MonoBehaviour
{
    int hits = 0;
    void OnCollosionEnter(Collision other)
    {
        if (other.gameObject.tag != "Hit")
        {
            hits++;
        }
    }
}
