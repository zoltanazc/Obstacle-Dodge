using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    public Material gotHitMat;
    //public BoxCollider gotHitBC;
    //public Rigidbody gotHitRB;
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player" && gameObject.tag == "Obstacle")
        {
            GetComponent<MeshRenderer>().material = gotHitMat;
            //gotHitBC.enabled = false;
            //Destroy(gotHitRB);
            gameObject.tag = "Hit";
            
        }
    }
}
