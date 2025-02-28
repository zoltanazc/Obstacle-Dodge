using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    public Material gotHitMat;
    public BoxCollider gotHitBoxC;
    void OnCollisionEnter()
    {
        if(gameObject.tag != "Wall")
        {
            GetComponent<MeshRenderer>().material = gotHitMat;
            gotHitBoxC.enabled = false;
        }
        
        
    }
}
